#! /usr/bin/env fish

echo "Using $(fish --version)"

set diTestProject "ShopifySharp.Extensions.DependencyInjection.Tests/ShopifySharp.Extensions.DependencyInjection.Tests.csproj"
set integrationTestProject "ShopifySharp.Tests.Integration/ShopifySharp.Tests.Integration.csproj"

set integrationFramework "net10.0"

# Load utility functions
set utilsFilePath (dirname (status --current-filename))"/utils.fish"
source "$utilsFilePath"

# Build and run the the tests for the DI and integration projects all at once
echo "Testing DI project."
buildProject "$diTestProject"; or exit 1;
executeTests \
    "ShopifySharp.Extensions.DependencyInjection" \
    "$netCoreApp" \
    "$diTestProject"
success "DI tests succeeded."

echo "Testing integration project."
buildProject "$integrationTestProject"; or exit 1;
executeTests \
    "ShopifySharp.Integration.Tests" \
    "$integrationFramework" \
    "$integrationTestProject"
success "Integration tests succeeded."

# Build the test project once, then let all individual test runs skip build.
echo "Building test project."
buildProject "$testProjectFile"; or exit 1;
success "Test project build succeeded."

# Regex for parsing categories from Trait attributes in test files
set categoryRegex "Trait\(['\"]Category['\"], ['\"]([A-Za-z]+)['\"]"
set categories

# Read every C# file in the test directory and parse the categories
for file in (ls ./ShopifySharp.Tests/*.cs)
    for category in (string match -agr "$categoryRegex" (cat "$file"))
        switch (string lower "$category")
            case "dotnetframework"
                # This is a .NET Framework test, it will be run explicitly after the other categories.

            case "shopifyexception"
                # This is a test of Shopify rate limit exceptions, save it for last.

            case "*"
                set -a categories "$category"
        end
    end
end

# Run category tests
if command -q parallel
    # Tests can be run in parallel. Run up to five test categories at once.
    set threads 5
    # This is a little weird, but parallel needs to run fish and source the utils file so it can call the executeTests function
    set fishCommand "source $utilsFilePath; and executeTests {} $netCoreApp; and exit 0"

    parallel \
        -j "$threads" \
        --halt-on-error 1 \
        fish -c \"$fishCommand\" \
        ::: $categories
    or exit 1;

else
    warn "GNU Parallel is not installed or could not be found. Testing categories one by one."

    for category in $categories
        executeTests "$category" "$netCoreApp"
    end
end

# Run .NET Framework tests using .NET Framework 4.7.2
if ! isArm64
    # TODO: these tests need to be run on a Windows machine, they do not run on Linux/macOS
    warn ".NET Framework tests are temporarily disabled."
    #executeTests "DotNetFramework" "$netFramework"
else
    warn "Machine is running on arm64 which does not support .NET Framework. Unable to run .NET Framework tests."
end

# Run Shopify exception tests which attempt to trip the rate limit
executeTests "ShopifyException" "$netCoreApp"

exit 0
