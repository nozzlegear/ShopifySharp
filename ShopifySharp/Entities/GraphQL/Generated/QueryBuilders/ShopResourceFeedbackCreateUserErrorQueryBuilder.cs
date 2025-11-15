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

public class ShopResourceFeedbackCreateUserErrorQueryBuilder() : GraphQueryBuilder<ShopResourceFeedbackCreateUserError>("query shopResourceFeedbackCreateUserError")
{
    public ShopResourceFeedbackCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ShopResourceFeedbackCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ShopResourceFeedbackCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}