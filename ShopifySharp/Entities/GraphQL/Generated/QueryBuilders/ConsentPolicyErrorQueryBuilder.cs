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

public class ConsentPolicyErrorQueryBuilder() : GraphQueryBuilder<ConsentPolicyError>("query consentPolicyError")
{
    public ConsentPolicyErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ConsentPolicyErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ConsentPolicyErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}