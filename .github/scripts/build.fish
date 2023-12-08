#! /usr/bin/env fish

echo "Using $(fish --version)"

# Load utility functions
set utilsFilePath (dirname (status --current-filename))"/utils.fish"
source "$utilsFilePath"

if ! set -q "GITHUB_RUN_NUMBER"
    error "Github run number (\$GITHUB_RUN_NUMBER) environment variable not set, cannot create prerelease build."
    exit 1
end

set revision "b$GITHUB_RUN_NUMBER"
set outputDir "$ARTIFACT_DIR"

# Pack the projects
# TODO: only pack projects that have git changes
packProject "$revision" "$outputDir" "ShopifySharp/ShopifySharp.csproj"
packProject "$revision" "$outputDir" "ShopifySharp.Extensions.DependencyInjection/ShopifySharp.Extensions.DependencyInjection.csproj"
packProject "$revision" "$outputDir" "ShopifySharp.Experimental/ShopifySharp.Experimental.fsproj"

exit 0
