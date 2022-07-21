#! /usr/bin/env fish

# Load utility functions
set utilsFilePath (dirname (status -f))"/utils.fish"
source "$utilsFilePath"

set newVersion "$argv[1]"

if test -z "$newVersion"
    set scriptName (basename (status -f))

    error "Missing new version value."
    warn "Usage: "
    warn "    ./$scriptName [newVersion]"
    exit 1
end

# Use sed to replace the <VersionPrefix>1.2.3</VersionPrefix> element in the project file
sed -i "" -e "s/<VersionPrefix>.*<\/VersionPrefix>/<VersionPrefix>$newVersion<\/VersionPrefix>/" "ShopifySharp/ShopifySharp.csproj"
