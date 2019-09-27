#! /bin/pwsh

$artifacts = "./artifacts";

dotnet restore;
dotnet build -c Release;

# Get the prerelease version suffix from AppVeyor's build revision
# Source: https://github.com/another-guy/Mirror/blob/9034cd0d6ee6ec072469f6c0f07bdb16b4b5764e/Build.ps1
$revision = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
$revision = "b{0:D5}" -f [convert]::ToInt32($revision, 10)

# Get a list of the projects that will be built and packed (those that aren't test projects)
$projects = gci "./ShopifySharp*/*.*sproj" | where-object -filterscript { $_ -inotmatch "tests" } 

# Pack the projects as both release and prerelease versions
# TODO: use the following source to create a script that knows when to pack as release or prerelease
# example script: https://github.com/another-guy/Mirror/blob/9034cd0d6ee6ec072469f6c0f07bdb16b4b5764e/Build.ps1
$projects | % { dotnet pack --no-build -c Release -o $artifacts $_ }
$projects | % { dotnet pack --no-build -c Release -o $artifacts --version-suffix $revision $_ }

# Gather all nuget packages and push them to AppVeyor artifacts
gci "./ShopifySharp*/$artifacts/*.nupkg" | % {
    Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName $_.Name
}
