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

public class ProductBundleMutationUserErrorQueryBuilder() : GraphQueryBuilder<ProductBundleMutationUserError>("query productBundleMutationUserError")
{
    public ProductBundleMutationUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductBundleMutationUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductBundleMutationUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}