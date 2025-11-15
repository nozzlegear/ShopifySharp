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

public class DelegateAccessTokenDestroyUserErrorQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenDestroyUserError>("query delegateAccessTokenDestroyUserError")
{
    public DelegateAccessTokenDestroyUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DelegateAccessTokenDestroyUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DelegateAccessTokenDestroyUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}