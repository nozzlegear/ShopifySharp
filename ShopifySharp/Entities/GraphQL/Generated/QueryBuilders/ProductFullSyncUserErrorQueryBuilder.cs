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

public class ProductFullSyncUserErrorQueryBuilder() : GraphQueryBuilder<ProductFullSyncUserError>("query productFullSyncUserError")
{
    public ProductFullSyncUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductFullSyncUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductFullSyncUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}