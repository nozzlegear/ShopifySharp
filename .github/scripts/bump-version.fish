#! /usr/bin/env fish

# Load utility functions
set utilsFilePath (dirname (status -f))"/utils.fish"
source "$utilsFilePath"

function printHelpAndExit -a errorMessage
    set scriptName (basename (status -f))
    if set -q errorMessage
        error "$errorMessage"
    end
    warn "Usage: "
    warn "    ./$scriptName [newVersion] [package target]"
    if status --is-interactive
        return 1
    else
        exit 1
    end
end

set newVersion "$argv[1]"

if test -z "$newVersion"
    printHelpAndExit "Missing new version value."
end

switch (string lower "$argv[2]")
    case "shopifysharp"
        set project "shopifysharp"
        set projectFile "ShopifySharp/ShopifySharp.csproj"
    case "shopifysharp-di"
        set project "shopifysharp-di"
        set projectFile "ShopifySharp.Extensions.DependencyInjection/ShopifySharp.Extensions.DependencyInjection.csproj"
    case "*"
        printHelpAndExit "Missing valid package target. Expected shopifysharp or shopifysharp-di."
end

function sed
    # Sed behaves differently between macos and linux
    # https://stackoverflow.com/a/57766728
    if test (uname -s) = "Darwin"
        command sed -i "" $argv
    else
        command sed -i $argv
    end
end

# Use sed to replace the <VersionPrefix>1.2.3</VersionPrefix> element in the project file
sed -e "s/<VersionPrefix>.*<\/VersionPrefix>/<VersionPrefix>$newVersion<\/VersionPrefix>/" "$projectFile"
