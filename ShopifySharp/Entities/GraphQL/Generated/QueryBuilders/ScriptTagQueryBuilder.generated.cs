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

public class ScriptTagQueryBuilder() : GraphQueryBuilder<ScriptTag>("scriptTag")
{
    public ScriptTagQueryBuilder AddFieldCache()
    {
        AddField("cache");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldDisplayScope()
    {
        AddField("displayScope");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldSrc()
    {
        AddField("src");
        return this;
    }

    public ScriptTagQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}