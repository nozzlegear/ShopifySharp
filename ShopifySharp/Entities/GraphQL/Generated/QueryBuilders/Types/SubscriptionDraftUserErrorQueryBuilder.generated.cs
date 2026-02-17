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
    public sealed class SubscriptionDraftUserErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>
    {
        protected override SubscriptionDraftUserErrorQueryBuilder Self => this;

        public SubscriptionDraftUserErrorQueryBuilder() : this("subscriptionDraftUserError")
        {
        }

        public SubscriptionDraftUserErrorQueryBuilder(string name) : base(new Query<SubscriptionDraftUserError>(name))
        {
        }

        public SubscriptionDraftUserErrorQueryBuilder(IQuery<SubscriptionDraftUserError> query) : base(query)
        {
        }

        public SubscriptionDraftUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionDraftUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SubscriptionDraftUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}