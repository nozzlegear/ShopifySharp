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

public class SEOQueryBuilder() : GraphQueryBuilder<SEO>("sEO")
{
    public SEOQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SEOQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}