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
    public sealed class SubscriptionContractStatusUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractStatusUpdateUserError, SubscriptionContractStatusUpdateUserErrorQueryBuilder>
    {
        protected override SubscriptionContractStatusUpdateUserErrorQueryBuilder Self => this;

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder() : this("subscriptionContractStatusUpdateUserError")
        {
        }

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder(string name) : base(new Query<SubscriptionContractStatusUpdateUserError>(name))
        {
        }

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder(IQuery<SubscriptionContractStatusUpdateUserError> query) : base(query)
        {
        }

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionContractStatusUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}