#! /bin/pwsh

dotnet restore --verbosity quiet;

# Get a list of the projects that will be built and packed (those that aren't test projects)
$projects = gci "./ShopifySharp*/*.*sproj" | where-object -filterscript { $_ -inotmatch "tests" } 

# Check if the latest commit has been tagged for release. 
# If so, pack the project as release artifacts.
# If not, pack the project as prerelease artifacts.
# Source: https://github.com/another-guy/Mirror/blob/9034cd0d6ee6ec072469f6c0f07bdb16b4b5764e/Build.ps1
$tagOfHead = iex 'git tag -l --contains HEAD'
$artifacts = "./artifacts";

if ([string]::IsNullOrEmpty($tagOfHead))
{
    # Get the prerelease version suffix from AppVeyor's build revision
    $revision = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
    $revision = "b{0:D5}" -f [convert]::ToInt32($revision, 10)
    $projects | % { dotnet pack --verbosity quiet -c Release -o $artifacts --version-suffix $revision $_ }
}
else
{
    # Unused, but we could also compare that the VersionSuffix attributes of a project match the tag and refuse if they don't.
    $projects | % {
        [xml]$projectFile = Get-Content $_
        $projectVersion = $projectFile.Project.PropertyGroup.VersionPrefix.Get(0)

        if ($tagOfHead.Trim() -ne $projectVersion.Trim()) {
            write-host "WARNING: Version $projectVersion of project $($_.Name) does not match git tag $tagOfHead." -ForegroundColor yellow
        }
    }
    
    $projects | % { dotnet pack --verbosity quiet -c Release -o $artifacts $_ }
}

# Gather all nuget packages and push them to AppVeyor artifacts
gci "./ShopifySharp*/$artifacts/*.nupkg" | % {
    Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName $_.Name
}
