#! /usr/bin/env fish

git clean -df ShopifySharp/Entities/GraphQL/Generated
and git checkout ShopifySharp/Entities/GraphQL/Generated
rm -r ShopifySharp/Entities/GraphQL/Generated
./regenerate.fish
or return 1
dotnet build ShopifySharp

