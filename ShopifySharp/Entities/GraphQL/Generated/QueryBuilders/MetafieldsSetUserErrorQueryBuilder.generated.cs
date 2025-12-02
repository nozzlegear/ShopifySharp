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

public class MetafieldsSetUserErrorQueryBuilder() : GraphQueryBuilder<MetafieldsSetUserError>("metafieldsSetUserError")
{
    public MetafieldsSetUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MetafieldsSetUserErrorQueryBuilder AddFieldElementIndex()
    {
        AddField("elementIndex");
        return this;
    }

    public MetafieldsSetUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MetafieldsSetUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}