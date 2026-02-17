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
    public sealed class SubscriptionDraftDiscountUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftDiscountUpdatePayload, SubscriptionDraftDiscountUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftDiscountUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftDiscountUpdateArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountUpdateOperationQueryBuilder Self => this;

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder() : this("subscriptionDraftDiscountUpdate")
        {
        }

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftDiscountUpdatePayload>(name))
        {
            Arguments = new SubscriptionDraftDiscountUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder(IQuery<SubscriptionDraftDiscountUpdatePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder DiscountUpdated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftDiscountUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}