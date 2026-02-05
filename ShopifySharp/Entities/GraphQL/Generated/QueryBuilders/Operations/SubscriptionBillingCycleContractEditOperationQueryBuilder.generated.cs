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
    public sealed class SubscriptionBillingCycleContractEditOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractEditPayload, SubscriptionBillingCycleContractEditOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleContractEditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleContractEditArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleContractEditOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleContractEditOperationQueryBuilder() : this("subscriptionBillingCycleContractEdit")
        {
        }

        public SubscriptionBillingCycleContractEditOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractEditPayload>(name))
        {
            Arguments = new SubscriptionBillingCycleContractEditArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractEditOperationQueryBuilder(IQuery<SubscriptionBillingCycleContractEditPayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleContractEditArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractEditOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionBillingCycleContractEditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}