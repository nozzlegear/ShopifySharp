#! /bin/pwsh

<#
.SYNOPSIS
  This is a helper function that runs a scriptblock and checks the PS variable $lastexitcode
  to see if an error occcured. If an error is detected then an exception is thrown.
  This function allows you to run command-line programs without having to
  explicitly check the $lastexitcode variable.
.EXAMPLE
  exec { svn info $repository_trunk } "Error executing SVN. Please verify SVN command-line client is installed"
.SOURCE
  https://github.com/another-guy/Mirror/blob/9034cd0d6ee6ec072469f6c0f07bdb16b4b5764e/Build.ps1
#>
function Exec
{
    [CmdletBinding()]
    param(
        [Parameter(Position=0,Mandatory=1)][scriptblock]$cmd,
        [Parameter(Position=1,Mandatory=0)][string]$errorMessage = ($msgs.error_bad_command -f $cmd)
    )
    & $cmd
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}

echo "============================ RESTORING DEPENDENCIES ==========================="
exec { & dotnet restore --verbosity quiet }

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
    echo "============================= PACKING FOR PRERELEASE ==========================="
    # Get the prerelease version suffix from AppVeyor's build revision
    $revision = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
    $revision = "b{0:D5}" -f [convert]::ToInt32($revision, 10)
    $projects | % { 
        exec { & dotnet pack --verbosity quiet -c Release -o $artifacts --version-suffix $revision $_ }
        echo "Packed $($_.Name) for prerelease."
    }
}
else
{
    echo "============================= PACKING FOR RELEASE ==========================="
    # Unused, but we could also compare that the VersionSuffix attributes of a project match the tag and refuse if they don't.
    $projects | % {
        [xml]$projectFile = Get-Content $_
        $projectVersion = $projectFile.Project.PropertyGroup.VersionPrefix.Get(0)

        if ($tagOfHead.Trim() -ne $projectVersion.Trim()) {
            write-host "WARNING: Version $projectVersion of project $($_.Name) does not match git tag $tagOfHead." -ForegroundColor yellow
        }
    }

    $projects | % { 
        exec { & dotnet pack --verbosity quiet -c Release -o $artifacts $_ }
        echo "Packed $($_.Name) for release."
    }
}

echo "============================= PUSHING APPVEYOR ARTIFACTS ==========================="
# Gather all nuget packages and push them to AppVeyor artifacts
$packed = gci "./ShopifySharp*/$artifacts/*.nupkg"
echo "Found $($packed.Count) artifacts to push."
$packed | % {
    exec { Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName $_.Name }
    echo "Pushed $($_.Name) artifact."
}
