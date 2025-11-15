#! /usr/bin/env fish

# Clean and remove existing generated files, we want a clean base when regenerating
./clean.fish
or return 1

rm -r ShopifySharp/Entities/GraphQL/Generated

dotnet run --project ShopifySharp.GraphQL.Parser.CLI -- \
    generate \
    --nullable true \
    --casing camel \
    -t ShopifySharp/Entities/GraphQL/Generated/Types \
    -b ShopifySharp/Entities/GraphQL/Generated/QueryBuilders \
    graphql.schema.graphql
