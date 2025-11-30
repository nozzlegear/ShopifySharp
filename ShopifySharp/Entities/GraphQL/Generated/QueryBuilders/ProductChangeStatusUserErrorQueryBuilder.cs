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

public class ProductChangeStatusUserErrorQueryBuilder() : GraphQueryBuilder<ProductChangeStatusUserError>("query productChangeStatusUserError")
{
    public ProductChangeStatusUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductChangeStatusUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductChangeStatusUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}