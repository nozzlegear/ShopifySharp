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
    public sealed class SubscriptionDraftDiscountCodeApplyOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountCodeApplyPayload, SubscriptionDraftDiscountCodeApplyOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftDiscountCodeApplyPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftDiscountCodeApplyArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountCodeApplyOperationQueryBuilder Self => this;

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder() : this("subscriptionDraftDiscountCodeApply")
        {
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountCodeApplyPayload>(name))
        {
            Arguments = new SubscriptionDraftDiscountCodeApplyArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder(IQuery<SubscriptionDraftDiscountCodeApplyPayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountCodeApplyArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionAppliedCodeDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionAppliedCodeDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}