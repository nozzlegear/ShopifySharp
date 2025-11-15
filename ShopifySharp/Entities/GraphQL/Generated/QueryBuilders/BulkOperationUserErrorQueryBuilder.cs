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

public class BulkOperationUserErrorQueryBuilder() : GraphQueryBuilder<BulkOperationUserError>("query bulkOperationUserError")
{
    public BulkOperationUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public BulkOperationUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public BulkOperationUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}