#!/usr/bin/env fish

# Generate GraphQL types using the CLI tool
# Usage: generate-types.fish [schema_version]

set schema_version $argv[1]

if test -n "$schema_version"
    echo "Generating types for API version: $schema_version"
    dotnet run --project ShopifySharp.GraphQL.Parser.CLI/ShopifySharp.GraphQL.Parser.CLI.csproj -- generate --schema-version "$schema_version" --output ShopifySharp/Entities/GraphQL/Generated
else
    echo "Generating types using existing schema file (future: will update current version)"
    dotnet run --project ShopifySharp.GraphQL.Parser.CLI/ShopifySharp.GraphQL.Parser.CLI.csproj -- generate --schema graphql.schema.graphql --output ShopifySharp/Entities/GraphQL/Generated
end