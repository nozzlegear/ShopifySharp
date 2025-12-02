#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductSetUserErrorQueryBuilder() : GraphQueryBuilder<ProductSetUserError>("productSetUserError")
{
    public ProductSetUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductSetUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductSetUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}