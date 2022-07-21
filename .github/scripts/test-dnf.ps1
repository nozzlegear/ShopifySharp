#! /usr/bin/env pwsh

$arguments = @{
    "-configuration" = "Release"
    "-framework" = "net472"
    "-verbosity" = "quiet"
    "-logger" = "trx;LogFileName=DotNetFramework.trx"
    "-results-directory" = "TestResults"
    "-filter" = "Category=DotNetFramework"
}

echo "Beginning .NET Framework tests..."

dotnet test @arguments "ShopifySharp.Tests/ShopifySharp.Tests.csproj"

if ($?) {
    echo ""
    echo ".NET Framework tests passed."
    exit 0
} else {
    echo ""
    echo ".NET Framework tests failed!"
    exit 1
}
