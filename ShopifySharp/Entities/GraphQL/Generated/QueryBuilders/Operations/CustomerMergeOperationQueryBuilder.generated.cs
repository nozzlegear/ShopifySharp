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
    public sealed class CustomerMergeOperationQueryBuilder : FieldsQueryBuilderBase<CustomerMergePayload, CustomerMergeOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerMergePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerMergeArgumentsBuilder Arguments { get; }
        protected override CustomerMergeOperationQueryBuilder Self => this;

        public CustomerMergeOperationQueryBuilder() : this("customerMerge")
        {
        }

        public CustomerMergeOperationQueryBuilder(string name) : base(new Query<CustomerMergePayload>(name))
        {
            Arguments = new CustomerMergeArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergeOperationQueryBuilder(IQuery<CustomerMergePayload> query) : base(query)
        {
            Arguments = new CustomerMergeArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergeOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CustomerMergeOperationQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }

        public CustomerMergeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeUserError>(query);
            return this;
        }
    }
}