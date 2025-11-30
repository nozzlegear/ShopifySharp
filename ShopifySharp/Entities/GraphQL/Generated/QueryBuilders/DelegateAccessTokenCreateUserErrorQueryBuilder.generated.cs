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

public class DelegateAccessTokenCreateUserErrorQueryBuilder() : GraphQueryBuilder<DelegateAccessTokenCreateUserError>("delegateAccessTokenCreateUserError")
{
    public DelegateAccessTokenCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DelegateAccessTokenCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DelegateAccessTokenCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}