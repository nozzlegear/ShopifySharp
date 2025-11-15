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

public class LinkQueryBuilder() : GraphQueryBuilder<Link>("query link")
{
    public LinkQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }

    public LinkQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }

    public LinkQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}