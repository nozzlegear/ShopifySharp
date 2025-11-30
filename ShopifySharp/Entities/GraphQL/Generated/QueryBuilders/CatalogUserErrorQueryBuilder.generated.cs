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

public class CatalogUserErrorQueryBuilder() : GraphQueryBuilder<CatalogUserError>("catalogUserError")
{
    public CatalogUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CatalogUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CatalogUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}