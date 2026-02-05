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
    public sealed class SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountCodeApplyPayload, SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder>
    {
        protected override SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder Self => this;

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder() : this("subscriptionDraftDiscountCodeApplyPayload")
        {
        }

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountCodeApplyPayload>(name))
        {
        }

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder(IQuery<SubscriptionDraftDiscountCodeApplyPayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionAppliedCodeDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionAppliedCodeDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}