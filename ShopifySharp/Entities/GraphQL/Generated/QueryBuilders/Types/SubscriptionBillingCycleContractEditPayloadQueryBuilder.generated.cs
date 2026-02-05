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
    public sealed class SubscriptionBillingCycleContractEditPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractEditPayload, SubscriptionBillingCycleContractEditPayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleContractEditPayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleContractEditPayloadQueryBuilder() : this("subscriptionBillingCycleContractEditPayload")
        {
        }

        public SubscriptionBillingCycleContractEditPayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractEditPayload>(name))
        {
        }

        public SubscriptionBillingCycleContractEditPayloadQueryBuilder(IQuery<SubscriptionBillingCycleContractEditPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractEditPayloadQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionBillingCycleContractEditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}