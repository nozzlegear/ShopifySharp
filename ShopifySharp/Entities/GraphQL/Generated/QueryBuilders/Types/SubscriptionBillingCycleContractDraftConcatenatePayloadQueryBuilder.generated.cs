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
    public sealed class SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractDraftConcatenatePayload, SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder() : this("subscriptionBillingCycleContractDraftConcatenatePayload")
        {
        }

        public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractDraftConcatenatePayload>(name))
        {
        }

        public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder(IQuery<SubscriptionBillingCycleContractDraftConcatenatePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}