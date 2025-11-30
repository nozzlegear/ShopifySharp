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

public class ProductOptionsCreateUserErrorQueryBuilder() : GraphQueryBuilder<ProductOptionsCreateUserError>("productOptionsCreateUserError")
{
    public ProductOptionsCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ProductOptionsCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ProductOptionsCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}