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

public class CustomerMergeRequestQueryBuilder() : GraphQueryBuilder<CustomerMergeRequest>("customerMergeRequest")
{
    public CustomerMergeRequestQueryBuilder AddFieldCustomerMergeErrors(Func<CustomerMergeErrorQueryBuilder, CustomerMergeErrorQueryBuilder> build)
    {
        AddField<CustomerMergeError, CustomerMergeErrorQueryBuilder>("customerMergeErrors", build);
        return this;
    }

    public CustomerMergeRequestQueryBuilder AddFieldJobId()
    {
        AddField("jobId");
        return this;
    }

    public CustomerMergeRequestQueryBuilder AddFieldResultingCustomerId()
    {
        AddField("resultingCustomerId");
        return this;
    }

    public CustomerMergeRequestQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}