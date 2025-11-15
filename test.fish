#! /usr/bin/env fish

./regenerate.fish
or return 1

dotnet build ./ShopifySharp/
