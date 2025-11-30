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

public class MetaobjectUserErrorQueryBuilder() : GraphQueryBuilder<MetaobjectUserError>("query metaobjectUserError")
{
    public MetaobjectUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MetaobjectUserErrorQueryBuilder AddFieldElementIndex()
    {
        AddField("elementIndex");
        return this;
    }

    public MetaobjectUserErrorQueryBuilder AddFieldElementKey()
    {
        AddField("elementKey");
        return this;
    }

    public MetaobjectUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MetaobjectUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}