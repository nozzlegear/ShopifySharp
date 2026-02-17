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
    public sealed class CustomerMergeUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerMergeUserError, CustomerMergeUserErrorQueryBuilder>
    {
        protected override CustomerMergeUserErrorQueryBuilder Self => this;

        public CustomerMergeUserErrorQueryBuilder() : this("customerMergeUserError")
        {
        }

        public CustomerMergeUserErrorQueryBuilder(string name) : base(new Query<CustomerMergeUserError>(name))
        {
        }

        public CustomerMergeUserErrorQueryBuilder(IQuery<CustomerMergeUserError> query) : base(query)
        {
        }

        public CustomerMergeUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerMergeUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerMergeUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}