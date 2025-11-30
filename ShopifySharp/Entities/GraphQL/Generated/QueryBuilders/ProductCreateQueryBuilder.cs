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

public class ProductCreateQueryBuilder() : GraphQueryBuilder<ProductCreatePayload>("query productCreate")
{
    public ProductCreateQueryBuilder AddArgumentMedia(ICollection<CreateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductCreateQueryBuilder AddArgumentProduct(ProductCreateInput? product)
    {
        AddArgument("product", product);
        return this;
    }
}