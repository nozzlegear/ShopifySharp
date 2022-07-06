#! /usr/bin/env fish

set config "Release"
set verbosity "quiet"
set netCoreApp "netcoreapp3.1"
set netFramework "net472"
set testDir "ShopifySharp.Tests"
set testProjectFile "$testDir/ShopifySharp.Tests.csproj"

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

function executeTests -a category -a framework -a projectFile
    if test -z "$framework"
        set framework "$netCoreApp"
    end

    if test -z "$projectFile"
        set projectFile "$testProjectFile"
    end

    if test -z "$category"
        set_color red
        echo "[error] Empty category passed to test function."

        if status --is-interactive
            return 1
        else
            exit 1
        end
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
        "$projectFile"
    )"; or begin
        echo "$testOutput"
        error "$category tests failed!"

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    if string match "No test is available" "$testOutput"
        # Bad category name, no test was run
        error "$category test was not run! Category may not exist."

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    success "$category tests passed."
    return 0
end

function buildProject -a projectFile
    if ! test -e "$projectFile"
        error "Project file at $projectFile does not exist"

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    dotnet build \
        -c "$config" \
        --verbosity "$verbosity" \
        "$projectFile"

    if test $status -ne 0
        if status --is-interactive
            return 1
        else
            exit 1
        end
    end
end

function packProject -a revision -a outputDir -a projectFile
    if test -z "$revision"
        error "revision value is empty."

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    if test -z "$outputDir"
        error "outputDir value is empty."

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    if ! test -e "$projectFile"
        error "Project file at $projectFile does not exist"

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    dotnet pack \
        -c "$config" \
        --version-suffix "$revision" \
        -o "$outputDir" \
        "$projectFile";
    or begin
        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    success "Packed $project for prerelease."

    dotnet pack \
        -c Release \
        -o "$outputDir" \
        "$projectFile"; 
    or begin
        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    success "Packed $projectFile for release."
end

function countMissingPolicies -a file -d "Counts the number of missing execution policies compared to the number of new ShopifySharp services instantiated in a file."
    if ! test -e "$file"
        error "File at $file does not exist."

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    set totalNewServices (count (rg "new \w+Service\(" "$file"))
    set totalPoliciesSet (count (rg "\.SetExecutionPolicy\(" "$file"))

    if test $totalPoliciesSet -ge $totalNewServices
        echo 0
    else
        echo (math $totalNewServices - $totalPoliciesSet)
    end
end

function countMisconfiguredFixtures -a file -d "Counts the number of missing or misconfigured test fixture classes in a file."
    if ! test -e "$file"
        error "File at $file does not exist."

        if status --is-interactive
            return 1
        else
            exit 1
        end
    end

    set totalAsyncLifetimes (count (rg "class \w+ *: *IAsyncLifetime" "$file"))
    set totalTestClasses (count (rg "class \w+ *: *IClassFixture<\w+>" "$file"))

    if test $totalAsyncLifetimes -gt $totalTestClasses
        # There are more IAsyncLifetime fixtures defined in this file than are used, which could indicate a misconfiguration
        echo (math $totalAsyncLifetimes - $totalTestClasses)
    else
        echo (math $totalTestClasses - $totalAsyncLifetimes)
    end
end
