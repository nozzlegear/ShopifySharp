#! /usr/bin/env fish

function success
    set_color green
    echo "$argv"
    set_color normal
end

function warn
    set_color yellow
    echo "[warning] $argv"
    set_color normal
end

function error
    set_color error
    echo "[error] $argv"
    set_color normal
end

if ! set -q "github_run_number"
    error "Github run number (\$github_run_number) environment variable not set, cannot create prerelease build."
    exit 1
end

set revision "b$github_run_number"
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
