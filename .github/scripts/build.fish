#! /usr/bin/env fish

echo "Using $(fish --version)"

function success
    set_color green
    echo "$argv"
    set_color normal
end

function error
    set_color error
    echo "[error] $argv"
    set_color normal
end

if ! set -q "GITHUB_RUN_NUMBER"
    error "Github run number (\$GITHUB_RUN_NUMBER) environment variable not set, cannot create prerelease build."
    exit 1
end

set revision "b$GITHUB_RUN_NUMBER"
set outputDir "artifacts"
# Each project should be separated by a space. In Fish, this creates an array.
set projects "ShopifySharp/ShopifySharp.csproj" "ShopifySharp.Experimental/ShopifySharp.Experimental.fsproj"

for project in $projects
    dotnet pack -c Release --version-suffix "$revision" -o "$outputDir" "$project"
    or exit 1
    success "Packed $project for prerelease."

    dotnet pack -c Release -o "$outputDir" "$project"
    or exit 1
    success "Packed $project for release."
end
