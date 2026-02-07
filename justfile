# https://just.systems

# Path to the CLI project
cli_project := "ShopifySharp.GraphQL.Parser.CLI"
# Path to the generated GraphQL entitites folder
graph_entities := "ShopifySharp/Entities/GraphQL/Generated"
# Build configuration
config := "Release"
# Dotnet verbosity
verbosity := "minimal"
# Test frameworks
netCoreApp := "net10.0"
netFramework := "net472"

default:
    just --list

[private]
[script]
_buildCliProject:
    if [ ! -d "{{cli_project}}/bin/Release" ]; then
        dotnet build --configuration Release
    fi

# Builds and packages the project for both prerelease and release configurations.
[private]
_buildAndPack project revision outputDir:
    dotnet pack \
        -c "{{config}}" \
        --version-suffix "{{revision}}" \
        -o "{{outputDir}}" \
        --verbosity "{{verbosity}}" \
        "{{project}}"
    dotnet pack \
        -c "{{config}}" \
        -o "{{outputDir}}" \
        --verbosity "{{verbosity}}" \
        "{{project}}"

# Clean generated files
[group("graphql")]
clean:
    git clean -df "{{graph_entities}}"
    git checkout "{{graph_entities}}"

# Regenerates GraphQL types from the graphql.schema.graphql file
[group("graphql")]
regenerate: clean _buildCliProject
    rm -r "{{graph_entities}}"

    dotnet run --no-build \
        --configuration Release \
        --project "{{cli_project}}" \
        -- \
        generate \
        --nullable true \
        --casing camel \
        -t "{{graph_entities}}/Types" \
        -b "{{graph_entities}}/QueryBuilders" \
        graphql.schema.graphql

# Regenerates GraphQL types and then builds the ShopifySharp project to ensure they're valid
[group("graphql")]
regenerate-and-build: clean regenerate
    dotnet build --configuration Release "./ShopifySharp/"

[group("graphql")]
[arg("version", long="api-version")]
[arg("domain", long)]
[arg("token", long)]
[arg("output", long)]
download-graphql-schema version domain token output="": _buildCliProject
    #!/usr/bin/env bash
    set -euo pipefail
    output_file="{{ if output == "" { version + ".schema.json" } else { output } }}"
    dotnet run --no-build \
        --configuration Release \
        --project "{{cli_project}}" \
        -- \
        download \
        -o "$output_file" \
        --api-version "{{version}}" \
        --domain "{{domain}}" \
        --token "{{token}}"

# Converts a .json GraphQL schema to .graphql
[group("graphql")]
[arg("jsonSchemaFile", long="input")]
[arg("graphqlSchemaFile", long="output")]
convert-graphql-schema jsonSchemaFile graphqlSchemaFile:
    npx -- graphql-json-to-sdl@0.5.0 "{{jsonSchemaFile}}" "{{graphqlSchemaFile}}"

# Creates a pull request containing any changes to the graphql schema file and in the generated GraphQL types folder
[group("graphql")]
[script]
[arg("token", long)]
[arg("graphqlSchemaFile", long="schema-file")]
create-graphql-pr token graphqlSchemaFile:
    branch_name="graphql-types-update-$(date +%Y%m%d-%H%M%S)"

    echo "Creating branch: $branch_name"

    # Only set git config in CI environments
    if [ -n "${GITHUB_ACTIONS:-}" ]; then
        git config --local user.email "action@github.com"
        git config --local user.name "GitHub Action"
    fi

    git switch -C "$branch_name"
    git add ShopifySharp/Entities/GraphQL/Generated/ "{{graphqlSchemaFile}}"
    git add "{{graphqlSchemaFile}}"

    if [ git diff --staged --quiet ]; then
        echo "No changes to commit"
        exit 0
    fi

    git commit -m "Add/update GraphQL schema and generated GraphQL types

    Generated via automated workflow."

    git push origin "$branch_name"

    gh pr create \
        --title "Update GraphQL schema and generated types to API version $_flag_schema_file" \
        --body "## Summary
    - Added/updated GraphQL schema `$schema_name`
    - Cleaned output directory before generation
    - Updated GraphQL types generated from schema using ShopifySharp.GraphQL.Parser.CLI

    🤖 Generated via the [Generate GraphQL Types](https://github.com/nozzlegear/ShopifySharp/blob/master/.github/workflows/generate-graphql-types.yml) workflow." \
        --base master \
        --head "$branch_name"

# Build and pack projects for prerelease and release
[group("build")]
[script]
@build-and-pack runNumber outputDir:
    revision="b{{runNumber}}"

    echo "Building and packing projects with revision: $revision"
    echo "Output directory: {{outputDir}}"

    # TODO: only pack projects that have git changes? (Only if this is running in a workflow.)
    _buildAndPack "ShopifySharp/ShopifySharp.csproj" "$revision" "{{outputDir}}"
    _buildAndPack "ShopifySharp.Extensions.DependencyInjection/ShopifySharp.Extensions.DependencyInjection.csproj" "$revision" "{{outputDir}}"

# Run .NET Framework unit tests
[group("test")]
test-dnf:
    @echo "Testing .NET Framework tests..."
    dotnet test \
        -c "{{config}}" \
        -f "{{netFramework}}" \
        --verbosity "{{verbosity}}" \
        --logger "trx;LogFileName=DotNetFramework.trx" \
        --results-directory "TestResults" \
        --filter "Category=DotNetFramework" \
        "ShopifySharp.Tests/ShopifySharp.Tests.csproj"
    @echo ""
    @echo ".NET Framework tests passed."

# Run tests on the DI project.
[group("test")]
test-di:
    @echo "Testing ShopifySharp.Extensions.DependencyInjection..."
    dotnet test \
        -c "{{config}}" \
        -f "{{netCoreApp}}" \
        --verbosity "{{verbosity}}" \
        --logger "trx;LogFileName=ShopifySharp.Extensions.DependencyInjection.trx" \
        --results-directory "TestResults" \
        "ShopifySharp.Extensions.DependencyInjection.Tests/ShopifySharp.Extensions.DependencyInjection.Tests.csproj"
    @echo ""
    @echo "ShopifySharp.Extensions.DependencyInjection tests passed."

# Run integration tests.
[group("test")]
test-integration:
    @echo "Testing integration project..."
    dotnet test \
        -c "{{config}}" \
        -f "{{netCoreApp}}" \
        --verbosity "{{verbosity}}" \
        --logger "trx;LogFileName=ShopifySharp.Integration.Tests.trx" \
        --results-directory "TestResults" \
        "ShopifySharp.Tests.Integration/ShopifySharp.Tests.Integration.csproj"
    @echo ""
    @echo "Integration tests passed."

# Run unit tests on the main ShopifySharp project.
[group("test")]
test-main-project:
    @echo "Testing main project..."
    dotnet test \
        -c "{{config}}" \
        -f "{{netCoreApp}}" \
        --verbosity "{{verbosity}}" \
        --logger "trx;LogFileName=ShopifySharp.Tests.trx" \
        --results-directory "TestResults" \
        --filter "Category!=DotNetFramework" \
        "ShopifySharp.Tests/ShopifySharp.Tests.csproj"
    @echo ""
    @echo "Main project tests passed."

# Run all tests (DI, integration, and unit tests)
[group("test")]
test-everything: test-di test-integration test-dnf test-main-project
    @echo "All tests passed."

# Set package version for a project (used in release workflow)
[group("release")]
[script]
set-package-version version packageId:
    projectFile="{{packageId}}/{{packageId}}.csproj"

    echo "Setting version {{version}} for {{packageId}}"

    # Requires the dotnet-setversion tool
    setversion -p "{{version}}" "$projectFile"

# Publish packages to NuGet
[group("release")]
[script]
publish-to-nuget releaseType nugetToken artifactsDir:
    if [ "{{releaseType}}" = "--prerelease" ]; then
        echo "Publishing prerelease packages to NuGet..."
        # Prerelease packages have a `-b*.nupkg` suffix
        dotnet nuget push \
            --skip-duplicate \
            -k "{{nugetToken}}" \
            -s "https://api.nuget.org/v3/index.json" \
            "{{artifactsDir}}"/*-b*.nupkg
    elif [ "{{releaseType}}" = "--full-release" ]; then
        echo "Publishing full release packages to NuGet..."
        # Full release packages don't have a suffix (i.e. exclude -b*.nupkg)
        for package in "{{artifactsDir}}"/*.nupkg; do
            if [[ ! "$package" =~ -b[0-9]+\.nupkg$ ]]; then
                dotnet nuget push \
                    --skip-duplicate \
                    -k "{{nugetToken}}" \
                    -s "https://api.nuget.org/v3/index.json" \
                    "$package"
            fi
        done
    else
        echo "Error: Invalid release type. Use --prerelease or --full-release"
        exit 1
    fi

    echo "Publish complete."

# Generate service factory classes from T4 template
[group("build")]
[script]
generate-factories:
    template_path="ShopifySharp/Factories/FactoryServiceTemplate.tt"

    if [ ! -f "$template_path" ]; then
        echo "Error: Template file at $template_path does not exist."
        exit 1
    fi

    echo "Generating service factories from template..."

    for service_file in ShopifySharp/Services/*/I*Service.cs; do
        # Extract service name from interface definition (e.g., "public interface IProductService" -> "ProductService")
        service_name=$(rg -o -e "public interface I([A-Z]\w+)Service" "$service_file" | sed 's/public interface I//')

        if [ -n "$service_name" ]; then
            echo "Generating ${service_name}Factory..."
            factory_file_name="ShopifySharp/Factories/${service_name}Factory.cs"
            dotnet t4 -p "TypeName=${service_name}" -o "$factory_file_name" "$template_path"
        fi
    done

    echo "Factory generation complete."
