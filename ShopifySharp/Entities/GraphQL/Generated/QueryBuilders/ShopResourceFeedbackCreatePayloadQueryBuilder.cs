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

public class ShopResourceFeedbackCreatePayloadQueryBuilder() : GraphQueryBuilder<ShopResourceFeedbackCreatePayload>("query shopResourceFeedbackCreatePayload")
{
    public ShopResourceFeedbackCreatePayloadQueryBuilder AddFieldFeedback()
    {
        AddField("feedback");
        return this;
    }

    public ShopResourceFeedbackCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}