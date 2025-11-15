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

public class CustomerMergeErrorQueryBuilder() : GraphQueryBuilder<CustomerMergeError>("query customerMergeError")
{
    public CustomerMergeErrorQueryBuilder AddFieldErrorFields()
    {
        AddField("errorFields");
        return this;
    }

    public CustomerMergeErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}