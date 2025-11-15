#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CatalogCreateQueryBuilder() : GraphQueryBuilder<CatalogCreatePayload>("query catalogCreate")
{
    public CatalogCreateQueryBuilder AddArgumentInput(CatalogCreateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}