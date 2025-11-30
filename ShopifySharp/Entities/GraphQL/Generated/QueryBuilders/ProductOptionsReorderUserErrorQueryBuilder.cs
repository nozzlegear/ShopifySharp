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

public class ProductOptionsReorderUserErrorQueryBuilder() : GraphQueryBuilder<ProductOptionsReorderUserError>("query productOptionsReorderUserError")
{
    public ProductOptionsReorderUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductOptionsReorderUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductOptionsReorderUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}