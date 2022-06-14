#! /usr/bin/env fish

echo "Using $(fish --version)"

set config "Release"
set verbosity "quiet"
set netCoreApp "netcoreapp3.1"
set netFramework "net472"

function success
    set_color green
    echo "$argv"
    set_color normal
end

function warn
    # Surface warning messages in Github Actions: 
    # https://docs.github.com/en/actions/using-workflows/workflow-commands-for-github-actions#example-setting-a-warning-message
    set_color yellow
    echo "::warning ::$argv"
    set_color normal
end

function error
    # Surface error messages in Github Actions:
    # https://docs.github.com/en/actions/using-workflows/workflow-commands-for-github-actions#example-setting-an-error-message
    set_color red
    echo "::error ::$argv"
    set_color normal
end

function isArm64
    # Note that functions in fish return exit codes -- success is 0, failure is anything > 0
    if test (uname -m) = "arm64"
        return 0
    else
        return 1
    end
end

function printTestResults -a testOutput
    # Parse the test output for the line indicating how many tests were run
    # The `string match` function will automatically write to console if a match is found
    string match -er "Total tests:|Passed!|Failed!|Skipped!" "$line"

    echo "$testOutput" > testoutput.txt
end

function executeTests -a category -a framework
    if test -z "$framework"
        set framework "$netCoreApp"
    end

    if test -z "$category"
        set_color red
        echo "[error] Empty category passed to test function."
        exit 1
    end

    echo ""
    echo "Running $category tests..."

    set testOutput "$(dotnet test \
        -c "$config" \
        -f "$framework" \
        --verbosity "$verbosity" \
        --logger "trx;LogFileName=$category.trx" \
        --results-directory "TestResults" \
        --filter "Category=$category" \
        --no-build \
        "$testProjectFile"
    )"; or begin
        echo "$testOutput"
        error "$category tests failed!"
        exit 1
    end

    if string match "No test is available" "$testOutput"
        # Bad category name, no test was run
        error "$category test was not run! Category may not exist."
        exit 1
    end

    success "$category tests passed."
end

echo "Testing experimental project."

# Run the experimental project's tests all at once
dotnet test \
    -c "$config" \
    -f "$netCoreApp" \
    --verbosity "$verbosity" \
    --logger "trx;LogFileName=ShopifySharp.Experimental.trx" \
    "ShopifySharp.Experimental.Tests/ShopifySharp.Experimental.Tests.fsproj"
or exit 1

success "Experimental tests succeeded."

set testDir "ShopifySharp.Tests"
set testProjectFile "$testDir/ShopifySharp.Tests.csproj"

echo "Building test project."

# Build the test project once, then let all individual test runs skip build.
dotnet build \
    -c "$config" \
    --verbosity "$verbosity" \
    "$testProjectFile"
or exit 1

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
    # Tests can be run in parallel. Run up to three test categories at once.
    set threads 3

    parallel -j "$threads" --halt-on-error 1 executeTests "{}" "$netCoreApp" ::: $categories
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
