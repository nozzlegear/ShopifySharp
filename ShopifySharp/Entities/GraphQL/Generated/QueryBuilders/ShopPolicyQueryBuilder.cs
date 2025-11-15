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

public class ShopPolicyQueryBuilder() : GraphQueryBuilder<ShopPolicy>("query shopPolicy")
{
    public ShopPolicyQueryBuilder AddFieldBody()
    {
        AddField("body");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public ShopPolicyQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}