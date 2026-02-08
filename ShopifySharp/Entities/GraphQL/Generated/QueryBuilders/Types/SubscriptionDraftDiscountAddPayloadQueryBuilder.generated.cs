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
    public sealed class SubscriptionDraftDiscountAddPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountAddPayload, SubscriptionDraftDiscountAddPayloadQueryBuilder>
    {
        protected override SubscriptionDraftDiscountAddPayloadQueryBuilder Self => this;

        public SubscriptionDraftDiscountAddPayloadQueryBuilder() : this("subscriptionDraftDiscountAddPayload")
        {
        }

        public SubscriptionDraftDiscountAddPayloadQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountAddPayload>(name))
        {
        }

        public SubscriptionDraftDiscountAddPayloadQueryBuilder(IQuery<SubscriptionDraftDiscountAddPayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountAddPayloadQueryBuilder DiscountAdded(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountAdded");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountAddPayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}