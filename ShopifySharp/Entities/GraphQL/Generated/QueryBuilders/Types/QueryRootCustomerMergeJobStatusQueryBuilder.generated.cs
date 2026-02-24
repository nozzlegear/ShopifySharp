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
    public sealed class QueryRootCustomerMergeJobStatusQueryBuilder : FieldsQueryBuilderBase<CustomerMergeRequest, QueryRootCustomerMergeJobStatusQueryBuilder>, IHasArguments<QueryRootCustomerMergeJobStatusArgumentsBuilder>
    {
        public QueryRootCustomerMergeJobStatusArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerMergeJobStatusQueryBuilder Self => this;

        public QueryRootCustomerMergeJobStatusQueryBuilder(string name) : base(new Query<CustomerMergeRequest>(name))
        {
            Arguments = new QueryRootCustomerMergeJobStatusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder(IQuery<CustomerMergeRequest> query) : base(query)
        {
            Arguments = new QueryRootCustomerMergeJobStatusArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder SetArguments(Action<QueryRootCustomerMergeJobStatusArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder CustomerMergeErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeError>("customerMergeErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeError>(query);
            return this;
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder JobId()
        {
            base.InnerQuery.AddField("jobId");
            return this;
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }

        public QueryRootCustomerMergeJobStatusQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}