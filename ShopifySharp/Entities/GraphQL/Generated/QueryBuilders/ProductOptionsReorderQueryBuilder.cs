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

public class ProductOptionsReorderQueryBuilder() : GraphQueryBuilder<ProductOptionsReorderPayload>("query productOptionsReorder")
{
    public ProductOptionsReorderQueryBuilder AddArgumentOptions(ICollection<OptionReorderInput>? options)
    {
        AddArgument("options", options);
        return this;
    }

    public ProductOptionsReorderQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}