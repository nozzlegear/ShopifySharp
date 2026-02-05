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
    public sealed class SubscriptionDraftLineAddPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftLineAddPayload, SubscriptionDraftLineAddPayloadQueryBuilder>
    {
        protected override SubscriptionDraftLineAddPayloadQueryBuilder Self => this;

        public SubscriptionDraftLineAddPayloadQueryBuilder() : this("subscriptionDraftLineAddPayload")
        {
        }

        public SubscriptionDraftLineAddPayloadQueryBuilder(string name) : base(new Query<SubscriptionDraftLineAddPayload>(name))
        {
        }

        public SubscriptionDraftLineAddPayloadQueryBuilder(IQuery<SubscriptionDraftLineAddPayload> query) : base(query)
        {
        }

        public SubscriptionDraftLineAddPayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftLineAddPayloadQueryBuilder LineAdded(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineAdded");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLineAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}