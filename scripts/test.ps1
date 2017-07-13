# Run all tests before the ShopifyException tests, which aim to hit the rate limit and therefore break other tests.
$dir = "ShopifySharp.Tests";
$config = "Release";
$exceptionTestsFile = "ShopifyException_Tests.cs";
$tests = Get-ChildItem "$dir/*_Tests.cs" -exclude "$exceptionTestsFile";
# Add the Exception tests to the end of the array.
$tests += (Get-ChildItem "$dir/$exceptionTestsFile")[0];
$skippedTests = @();

# Build the project once, then let all tests skip build.
dotnet build -c $config;

foreach ($test in $tests) {
    $categoryName = $test.Name -replace "_Tests.cs","";

    write-host "";
    write-host "Running $categoryName tests.";

    $testOutput = dotnet test -c $config --filter "Category=$categoryName" --no-build "$dir/$dir.csproj";
    $testExitCode = $LastExitCode;
    $totalTestsLine = $testOutput -match "^Total tests:";
    
    write-host $totalTestsLine;

    if (([regex]::Match($output, "No test is available")).Success -eq $true) {
        # Bad category name, no test was run.
        write-host "$categoryName test in file $($test.Name) was not run! Category does not exist." -ForegroundColor "red";
        $skippedTests += $categoryName;
    }
    elseif ($testExitCode -ne 0 -or $output -contains "Test Run Failed.") {
        Write-Host "$categoryName tests failed:" -ForegroundColor "red";
        Write-Output $testOutput;
        $message = "$categoryName tests failed with exit code $testExitCode.";

        throw $message;
    }
    else {
        Write-Host "$categoryName tests passed." -ForegroundColor "Green";
    }
}

if ($skippedTests.Length -gt 0) {
    $skippedTests | % { write-host "$_ test was skipped. Does it exist?" -ForegroundColor "yellow" }
}