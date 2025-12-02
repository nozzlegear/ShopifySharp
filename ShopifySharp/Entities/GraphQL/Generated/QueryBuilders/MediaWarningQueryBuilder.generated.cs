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

public class MediaWarningQueryBuilder() : GraphQueryBuilder<MediaWarning>("mediaWarning")
{
    public MediaWarningQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MediaWarningQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}