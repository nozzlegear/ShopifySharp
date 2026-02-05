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
    public sealed class SubscriptionDraftDiscountRemovePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountRemovePayload, SubscriptionDraftDiscountRemovePayloadQueryBuilder>
    {
        protected override SubscriptionDraftDiscountRemovePayloadQueryBuilder Self => this;

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder() : this("subscriptionDraftDiscountRemovePayload")
        {
        }

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountRemovePayload>(name))
        {
        }

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder(IQuery<SubscriptionDraftDiscountRemovePayload> query) : base(query)
        {
        }

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }

        public SubscriptionDraftDiscountRemovePayloadQueryBuilder DiscountRemoved(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("discountRemoved");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}