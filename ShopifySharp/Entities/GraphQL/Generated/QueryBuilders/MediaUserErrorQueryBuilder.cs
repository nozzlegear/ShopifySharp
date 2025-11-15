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

public class MediaUserErrorQueryBuilder() : GraphQueryBuilder<MediaUserError>("query mediaUserError")
{
    public MediaUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MediaUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MediaUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}