#! /usr/bin/env fish

dotnet run --project ShopifySharp.GraphQL.Parser.CLI -- \
    generate \
    --nullable true \
    --casing camel \
    -t ShopifySharp/Entities/GraphQL/Generated/Types \
    -b ShopifySharp/Entities/GraphQL/Generated/QueryBuilders \
    graphql.schema.graphql
