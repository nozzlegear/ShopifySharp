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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractDraftCommitPayload, SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleContractDraftCommitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleContractDraftCommitArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder() : this("subscriptionBillingCycleContractDraftCommit")
        {
        }

        public SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractDraftCommitPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleContractDraftCommitArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder(IQuery<SubscriptionBillingCycleContractDraftCommitPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleContractDraftCommitArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEditedContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEditedContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEditedContract>(query);
            return this;
        }

        public SubscriptionBillingCycleContractDraftCommitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}