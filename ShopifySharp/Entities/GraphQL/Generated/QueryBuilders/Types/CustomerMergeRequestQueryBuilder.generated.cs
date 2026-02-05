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
    public sealed class CustomerMergeRequestQueryBuilder : FieldsQueryBuilderBase<CustomerMergeRequest, CustomerMergeRequestQueryBuilder>
    {
        protected override CustomerMergeRequestQueryBuilder Self => this;

        public CustomerMergeRequestQueryBuilder() : this("customerMergeRequest")
        {
        }

        public CustomerMergeRequestQueryBuilder(string name) : base(new Query<CustomerMergeRequest>(name))
        {
        }

        public CustomerMergeRequestQueryBuilder(IQuery<CustomerMergeRequest> query) : base(query)
        {
        }

        public CustomerMergeRequestQueryBuilder CustomerMergeErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeError>("customerMergeErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeError>(query);
            return this;
        }

        public CustomerMergeRequestQueryBuilder JobId()
        {
            base.InnerQuery.AddField("jobId");
            return this;
        }

        public CustomerMergeRequestQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }

        public CustomerMergeRequestQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}