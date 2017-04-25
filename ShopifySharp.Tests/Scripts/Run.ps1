# Run all tests except the ShopifyException tests, which aim to hit the rate limit and therefore break other tests.
# dotnet test --filter "Category!=ShopifyException"

$tests = gci *.cs | where { $_ -match "_Tests\.cs" };
$failed = @();

foreach ($test in $tests)
{
    write-host "TODO: Skip running the ShopifyException tests until all other tests have run." -ForegroundColor "yellow";

    $categoryName = $test.Name -replace "_Tests.cs","";

    write-host "Running $categoryName tests.";

    $testOutput = dotnet test --filter "Category=$categoryName";

    write-host $testOutput;

    if (([regex]::Match($output, "No test is available")).Success -eq $true)
    {
        # Bad category name, no test was run.
        write-host "$categoryName test in file $($test.Name) was not run! Category does not exist." -ForegroundColor "red";
    }

    write-host "TODO: Check for errors in test and quit if found." -ForegroundColor "yellow";
}

if ($LastExitCode -ne 0)
{
    throw "Test errors detected. Exiting before running ShopifyException tests.";
}

# Run the exception tests last
# dotnet test --filter "Category=ShopifyException"