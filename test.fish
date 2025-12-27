#! /usr/bin/env fish

git clean -df ShopifySharp/Entities/GraphQL/Generated
and git checkout ShopifySharp/Entities/GraphQL/Generated
rm -r ShopifySharp/Entities/GraphQL/Generated
./regenerate.fish
dotnet build ShopifySharp

