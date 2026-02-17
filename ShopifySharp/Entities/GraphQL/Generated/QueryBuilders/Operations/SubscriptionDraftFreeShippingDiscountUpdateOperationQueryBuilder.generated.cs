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
    public sealed class SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftFreeShippingDiscountUpdatePayload, SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftFreeShippingDiscountUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder Self => this;

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder() : this("subscriptionDraftFreeShippingDiscountUpdate")
        {
        }

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftFreeShippingDiscountUpdatePayload>(name))
        {
            Arguments = new SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder(IQuery<SubscriptionDraftFreeShippingDiscountUpdatePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftFreeShippingDiscountUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder DiscountUpdated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftFreeShippingDiscountUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}