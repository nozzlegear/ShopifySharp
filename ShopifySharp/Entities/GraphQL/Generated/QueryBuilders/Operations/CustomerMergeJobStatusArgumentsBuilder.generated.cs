#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerMergeJobStatusArgumentsBuilder : ArgumentsBuilderBase<CustomerMergeRequest, CustomerMergeJobStatusArgumentsBuilder>
    {
        protected override CustomerMergeJobStatusArgumentsBuilder Self => this;

        public CustomerMergeJobStatusArgumentsBuilder(IQuery<CustomerMergeRequest> query) : base(query)
        {
        }

        public CustomerMergeJobStatusArgumentsBuilder JobId(string? jobId)
        {
            base.InnerQuery.AddArgument("jobId", jobId);
            return this;
        }
    }
}