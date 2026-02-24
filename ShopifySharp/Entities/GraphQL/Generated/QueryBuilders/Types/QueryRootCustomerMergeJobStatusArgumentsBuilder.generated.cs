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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCustomerMergeJobStatusArgumentsBuilder : ArgumentsBuilderBase<CustomerMergeRequest?, QueryRootCustomerMergeJobStatusArgumentsBuilder>
    {
        protected override QueryRootCustomerMergeJobStatusArgumentsBuilder Self => this;

        public QueryRootCustomerMergeJobStatusArgumentsBuilder(IQuery<CustomerMergeRequest?> query) : base(query)
        {
        }

        public QueryRootCustomerMergeJobStatusArgumentsBuilder JobId(string? jobId)
        {
            base.InnerQuery.AddArgument("jobId", jobId);
            return this;
        }
    }
}