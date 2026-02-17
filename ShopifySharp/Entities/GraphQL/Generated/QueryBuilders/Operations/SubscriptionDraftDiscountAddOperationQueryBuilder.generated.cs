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
    public sealed class SubscriptionDraftDiscountAddOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountAddPayload, SubscriptionDraftDiscountAddOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftDiscountAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftDiscountAddArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountAddOperationQueryBuilder Self => this;

        public SubscriptionDraftDiscountAddOperationQueryBuilder() : this("subscriptionDraftDiscountAdd")
        {
        }

        public SubscriptionDraftDiscountAddOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountAddPayload>(name))
        {
            Arguments = new SubscriptionDraftDiscountAddArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountAddOperationQueryBuilder(IQuery<SubscriptionDraftDiscountAddPayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountAddArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountAddOperationQueryBuilder DiscountAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountAddOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}