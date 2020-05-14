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

write-host "============================ DEPLOYING PRERELEASE PACKAGES TO NUGET ==========================="
# Appveyor pushes a $artifacts variable which contains all artifacts pushed from the build script. 
# Prerelease artifacts are named like "ShopifySharp.1.2.3.b456789.npukg" or "ShopifySharp.Experimental.1.2.3.b456789.nupkg"
# Only publish those prerelease packages, and require manualy publishing for full releases. 
foreach ($artifactName in $artifacts.keys) {
    $artifact = $artifacts[$artifactName]
    $artifactPath = $artifact.path
    
    if ($artifactName -like "ShopifySharp.*.*.*.b*.nupkg" -or $artifactName -like "ShopifySharp.Experimental.*.*.*.b*.nupkg") {
        # TODO: publish package to nuget using dotnet publish
        exec { & dotnet nuget push -k "$env:NUGET_API_KEY" -s "https://nuget.org" "$artifactPath" }
        write-host "Pushed $($_.Name) artifact."
    }
}
