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
    public sealed class CustomerMergeableQueryBuilder : FieldsQueryBuilderBase<CustomerMergeable, CustomerMergeableQueryBuilder>
    {
        protected override CustomerMergeableQueryBuilder Self => this;

        public CustomerMergeableQueryBuilder() : this("customerMergeable")
        {
        }

        public CustomerMergeableQueryBuilder(string name) : base(new Query<CustomerMergeable>(name))
        {
        }

        public CustomerMergeableQueryBuilder(IQuery<CustomerMergeable> query) : base(query)
        {
        }

        public CustomerMergeableQueryBuilder ErrorFields()
        {
            base.InnerQuery.AddField("errorFields");
            return this;
        }

        public CustomerMergeableQueryBuilder IsMergeable()
        {
            base.InnerQuery.AddField("isMergeable");
            return this;
        }

        public CustomerMergeableQueryBuilder MergeInProgress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeRequestQueryBuilder> build)
        {
            var query = new Query<CustomerMergeRequest>("mergeInProgress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeRequest>(query);
            return this;
        }

        public CustomerMergeableQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }
    }
}