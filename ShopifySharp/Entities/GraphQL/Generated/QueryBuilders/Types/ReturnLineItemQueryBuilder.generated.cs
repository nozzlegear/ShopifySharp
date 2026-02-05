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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ReturnLineItemQueryBuilder : FieldsQueryBuilderBase<ReturnLineItem, ReturnLineItemQueryBuilder>
    {
        protected override ReturnLineItemQueryBuilder Self => this;

        public ReturnLineItemQueryBuilder() : this("returnLineItem")
        {
        }

        public ReturnLineItemQueryBuilder(string name) : base(new Query<ReturnLineItem>(name))
        {
        }

        public ReturnLineItemQueryBuilder(IQuery<ReturnLineItem> query) : base(query)
        {
        }

        public ReturnLineItemQueryBuilder CustomerNote()
        {
            base.InnerQuery.AddField("customerNote");
            return this;
        }

        public ReturnLineItemQueryBuilder FulfillmentLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("fulfillmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public ReturnLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnLineItemQueryBuilder ProcessableQuantity()
        {
            base.InnerQuery.AddField("processableQuantity");
            return this;
        }

        public ReturnLineItemQueryBuilder ProcessedQuantity()
        {
            base.InnerQuery.AddField("processedQuantity");
            return this;
        }

        public ReturnLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ReturnLineItemQueryBuilder RefundableQuantity()
        {
            base.InnerQuery.AddField("refundableQuantity");
            return this;
        }

        public ReturnLineItemQueryBuilder RefundedQuantity()
        {
            base.InnerQuery.AddField("refundedQuantity");
            return this;
        }

        public ReturnLineItemQueryBuilder RestockingFee(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RestockingFeeQueryBuilder> build)
        {
            var query = new Query<RestockingFee>("restockingFee");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RestockingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RestockingFee>(query);
            return this;
        }

        [Obsolete("Use `returnReasonDefinition` instead. This field will be removed in the future.")]
        public ReturnLineItemQueryBuilder ReturnReason()
        {
            base.InnerQuery.AddField("returnReason");
            return this;
        }

        public ReturnLineItemQueryBuilder ReturnReasonDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("returnReasonDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public ReturnLineItemQueryBuilder ReturnReasonNote()
        {
            base.InnerQuery.AddField("returnReasonNote");
            return this;
        }

        public ReturnLineItemQueryBuilder TotalWeight(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("totalWeight");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }

        public ReturnLineItemQueryBuilder UnprocessedQuantity()
        {
            base.InnerQuery.AddField("unprocessedQuantity");
            return this;
        }

        public ReturnLineItemQueryBuilder WithCodeDiscountedTotalPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("withCodeDiscountedTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}