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
    public sealed class SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractDraftCommitPayload, SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder>
    {
        protected override SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder Self => this;

        public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder() : this("subscriptionBillingCycleContractDraftCommitPayload")
        {
        }

        public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractDraftCommitPayload>(name))
        {
        }

        public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder(IQuery<SubscriptionBillingCycleContractDraftCommitPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEditedContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEditedContract>(query);
            return this;
        }

        public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}