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

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionAppliedCodeDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionAppliedCodeDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionAppliedCodeDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountCodeApplyOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}