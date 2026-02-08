#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CustomerMergeJobStatusOperationQueryBuilder : FieldsQueryBuilderBase<CustomerMergeRequest, CustomerMergeJobStatusOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerMergeRequest>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerMergeJobStatusArgumentsBuilder Arguments { get; }
        protected override CustomerMergeJobStatusOperationQueryBuilder Self => this;

        public CustomerMergeJobStatusOperationQueryBuilder() : this("customerMergeJobStatus")
        {
        }

        public CustomerMergeJobStatusOperationQueryBuilder(string name) : base(new Query<CustomerMergeRequest>(name))
        {
            Arguments = new CustomerMergeJobStatusArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergeJobStatusOperationQueryBuilder(IQuery<CustomerMergeRequest> query) : base(query)
        {
            Arguments = new CustomerMergeJobStatusArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergeJobStatusOperationQueryBuilder CustomerMergeErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeError>("customerMergeErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeError>(query);
            return this;
        }

        public CustomerMergeJobStatusOperationQueryBuilder JobId()
        {
            base.InnerQuery.AddField("jobId");
            return this;
        }

        public CustomerMergeJobStatusOperationQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }

        public CustomerMergeJobStatusOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}