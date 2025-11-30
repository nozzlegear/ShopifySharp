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

public class CustomerMergePayloadQueryBuilder() : GraphQueryBuilder<CustomerMergePayload>("customerMergePayload")
{
    public CustomerMergePayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public CustomerMergePayloadQueryBuilder AddFieldResultingCustomerId()
    {
        AddField("resultingCustomerId");
        return this;
    }

    public CustomerMergePayloadQueryBuilder AddFieldUserErrors(Func<CustomerMergeUserErrorQueryBuilder, CustomerMergeUserErrorQueryBuilder> build)
    {
        AddField<CustomerMergeUserError, CustomerMergeUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}