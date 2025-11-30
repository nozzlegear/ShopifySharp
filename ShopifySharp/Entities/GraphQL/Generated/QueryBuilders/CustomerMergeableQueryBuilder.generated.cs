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

public class CustomerMergeableQueryBuilder() : GraphQueryBuilder<CustomerMergeable>("customerMergeable")
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

    public CustomerMergeableQueryBuilder AddFieldMergeInProgress(Func<CustomerMergeRequestQueryBuilder, CustomerMergeRequestQueryBuilder> build)
    {
        AddField<CustomerMergeRequest, CustomerMergeRequestQueryBuilder>("mergeInProgress", build);
        return this;
    }

    public CustomerMergeableQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }
}