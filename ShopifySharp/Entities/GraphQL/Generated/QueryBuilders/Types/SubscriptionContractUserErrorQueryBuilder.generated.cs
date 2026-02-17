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
    public sealed class SubscriptionContractUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractUserError, SubscriptionContractUserErrorQueryBuilder>
    {
        protected override SubscriptionContractUserErrorQueryBuilder Self => this;

        public SubscriptionContractUserErrorQueryBuilder() : this("subscriptionContractUserError")
        {
        }

        public SubscriptionContractUserErrorQueryBuilder(string name) : base(new Query<SubscriptionContractUserError>(name))
        {
        }

        public SubscriptionContractUserErrorQueryBuilder(IQuery<SubscriptionContractUserError> query) : base(query)
        {
        }

        public SubscriptionContractUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionContractUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionContractUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}