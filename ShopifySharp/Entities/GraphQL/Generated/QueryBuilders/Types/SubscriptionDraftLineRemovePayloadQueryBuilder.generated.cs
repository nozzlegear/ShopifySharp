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
    public sealed class SubscriptionDraftLineRemovePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftLineRemovePayload, SubscriptionDraftLineRemovePayloadQueryBuilder>
    {
        protected override SubscriptionDraftLineRemovePayloadQueryBuilder Self => this;

        public SubscriptionDraftLineRemovePayloadQueryBuilder() : this("subscriptionDraftLineRemovePayload")
        {
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder(string name) : base(new Query<SubscriptionDraftLineRemovePayload>(name))
        {
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder(IQuery<SubscriptionDraftLineRemovePayload> query) : base(query)
        {
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder DiscountsUpdated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountsUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder LineRemoved(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLineRemovePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}