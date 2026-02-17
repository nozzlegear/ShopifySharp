#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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

        public SubscriptionBillingCycleContractEditOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionBillingCycleContractEditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}