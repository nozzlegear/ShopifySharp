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

write-host "============================ RESTORING DEPENDENCIES ==========================="
exec { & dotnet restore --verbosity quiet }

# Get a list of the projects that will be built and packed (those that aren't test projects)
$projects = gci "./ShopifySharp*/*.*sproj" | where-object -filterscript { $_ -inotmatch "tests" }

# Check if the latest commit has been tagged for release. 
# If so, pack the project as release artifacts.
# If not, pack the project as prerelease artifacts.
# Source: https://github.com/another-guy/Mirror/blob/9034cd0d6ee6ec072469f6c0f07bdb16b4b5764e/Build.ps1
$tagOfHead = iex 'git tag -l --contains HEAD'
$artifactsFolder = "./artifacts";

if ([string]::IsNullOrEmpty($tagOfHead))
{
    write-host "============================= PACKING FOR PRERELEASE ==========================="
    # Get the prerelease version suffix from AppVeyor's build revision
    $revision = @{ $true = $env:APPVEYOR_BUILD_NUMBER; $false = 1 }[$env:APPVEYOR_BUILD_NUMBER -ne $NULL];
    $revision = "b{0:D5}" -f [convert]::ToInt32($revision, 10)
    $projects | % { 
        exec { & dotnet pack -c Release -o $artifactsFolder --version-suffix $revision $_ }
        write-host "Packed $($_.Name) for prerelease." -ForegroundColor "green"
    }
}
else
{
    write-host "============================= PACKING FOR RELEASE ==========================="
    # Unused, but we could also compare that the VersionSuffix attributes of a project match the tag and refuse if they don't.
    $projects | % {
        [xml]$projectFile = Get-Content $_
        $projectVersion = $projectFile.Project.PropertyGroup.VersionPrefix.Get(0)

        if ($tagOfHead.Trim() -ne $projectVersion.Trim()) {
            write-host "WARNING: Version $projectVersion of project $($_.Name) does not match git tag $tagOfHead." -ForegroundColor yellow
        }
    }

    $projects | % { 
        exec { & dotnet pack -c Release -o $artifactsFolder $_ }
        write-host "Packed $($_.Name) for release." -ForegroundColor "green"
    }
}

write-host "============================= PUSHING APPVEYOR ARTIFACTS ==========================="
# Gather all nuget packages and push them to AppVeyor artifacts
# Depending on the version of dotnet, the artifacts folder may either be at root level, or in each project's own folder
$packedPath = "./ShopifySharp*/$artifactsFolder/*.nupkg"

if (! (test-path $packedPath)) 
{
    $packedPath = "$artifactsFolder/*.nupkg"
    
    if (! (test-path $packedPath)) 
    {
        gci "./"
        gci "./ShopifySharp"
        throw "Unable to locate artifacts folder."
    }
}

$packed = gci $packedPath 
write-host "Found $($packed.Count) artifacts to push."

$packed | % {
    exec { Push-AppveyorArtifact $_.FullName -FileName $_.Name -DeploymentName $_.Name }
    write-host "Pushed $($_.Name) artifact."
}
