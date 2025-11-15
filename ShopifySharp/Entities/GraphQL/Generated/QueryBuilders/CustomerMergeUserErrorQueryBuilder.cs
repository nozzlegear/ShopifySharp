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

public class CustomerMergeUserErrorQueryBuilder() : GraphQueryBuilder<CustomerMergeUserError>("query customerMergeUserError")
{
    public CustomerMergeUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerMergeUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerMergeUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}