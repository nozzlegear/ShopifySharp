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

public class ProductDeleteQueryBuilder() : GraphQueryBuilder<ProductDeletePayload>("query productDelete")
{
    public ProductDeleteQueryBuilder AddArgumentInput(ProductDeleteInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public ProductDeleteQueryBuilder AddArgumentSynchronous(bool? synchronous)
    {
        AddArgument("synchronous", synchronous);
        return this;
    }
}