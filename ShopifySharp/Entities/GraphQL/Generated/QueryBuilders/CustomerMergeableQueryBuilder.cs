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

public class CustomerMergeableQueryBuilder() : GraphQueryBuilder<CustomerMergeable>("query customerMergeable")
{
    public CustomerMergeableQueryBuilder AddFieldErrorFields()
    {
        AddField("errorFields");
        return this;
    }

    public CustomerMergeableQueryBuilder AddFieldIsMergeable()
    {
        AddField("isMergeable");
        return this;
    }

    public CustomerMergeableQueryBuilder AddFieldMergeInProgress()
    {
        AddField("mergeInProgress");
        return this;
    }

    public CustomerMergeableQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }
}