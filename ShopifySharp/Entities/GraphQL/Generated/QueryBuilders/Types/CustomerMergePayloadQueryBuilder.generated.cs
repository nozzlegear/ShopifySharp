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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CustomerMergePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerMergePayload, CustomerMergePayloadQueryBuilder>
    {
        protected override CustomerMergePayloadQueryBuilder Self => this;

        public CustomerMergePayloadQueryBuilder() : this("customerMergePayload")
        {
        }

        public CustomerMergePayloadQueryBuilder(string name) : base(new Query<CustomerMergePayload>(name))
        {
        }

        public CustomerMergePayloadQueryBuilder(IQuery<CustomerMergePayload> query) : base(query)
        {
        }

        public CustomerMergePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CustomerMergePayloadQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }

        public CustomerMergePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeUserError>(query);
            return this;
        }
    }
}