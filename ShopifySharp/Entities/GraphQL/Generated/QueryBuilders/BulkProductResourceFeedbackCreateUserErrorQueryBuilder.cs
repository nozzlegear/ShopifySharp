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

public class BulkProductResourceFeedbackCreateUserErrorQueryBuilder() : GraphQueryBuilder<BulkProductResourceFeedbackCreateUserError>("query bulkProductResourceFeedbackCreateUserError")
{
    public BulkProductResourceFeedbackCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public BulkProductResourceFeedbackCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public BulkProductResourceFeedbackCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}