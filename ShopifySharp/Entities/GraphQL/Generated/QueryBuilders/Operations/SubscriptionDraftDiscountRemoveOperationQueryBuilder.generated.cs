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
    public sealed class SubscriptionDraftDiscountRemoveOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountRemovePayload, SubscriptionDraftDiscountRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftDiscountRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftDiscountRemoveArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountRemoveOperationQueryBuilder Self => this;

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder() : this("subscriptionDraftDiscountRemove")
        {
        }

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountRemovePayload>(name))
        {
            Arguments = new SubscriptionDraftDiscountRemoveArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder(IQuery<SubscriptionDraftDiscountRemovePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountRemoveArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }

        public SubscriptionDraftDiscountRemoveOperationQueryBuilder DiscountRemoved(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("discountRemoved");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}