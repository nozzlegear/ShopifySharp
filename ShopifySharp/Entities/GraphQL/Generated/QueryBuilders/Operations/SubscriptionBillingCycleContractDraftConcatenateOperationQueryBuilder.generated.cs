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
    public sealed class SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleContractDraftConcatenatePayload, SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleContractDraftConcatenatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder() : this("subscriptionBillingCycleContractDraftConcatenate")
        {
        }

        public SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleContractDraftConcatenatePayload>(name))
        {
            Arguments = new SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder(IQuery<SubscriptionBillingCycleContractDraftConcatenatePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleContractDraftConcatenateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionBillingCycleContractDraftConcatenateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}