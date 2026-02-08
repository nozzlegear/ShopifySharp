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
    public sealed class FulfillmentOrderLineItemQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItem, FulfillmentOrderLineItemQueryBuilder>
    {
        protected override FulfillmentOrderLineItemQueryBuilder Self => this;

        public FulfillmentOrderLineItemQueryBuilder() : this("fulfillmentOrderLineItem")
        {
        }

        public FulfillmentOrderLineItemQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItem>(name))
        {
        }

        public FulfillmentOrderLineItemQueryBuilder(IQuery<FulfillmentOrderLineItem> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemQueryBuilder FinancialSummaries(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemFinancialSummaryQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemFinancialSummary>("financialSummaries");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemFinancialSummaryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemFinancialSummary>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder InventoryItemId()
        {
            base.InnerQuery.AddField("inventoryItemId");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder LineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder ProductTitle()
        {
            base.InnerQuery.AddField("productTitle");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder RemainingQuantity()
        {
            base.InnerQuery.AddField("remainingQuantity");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Warnings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemWarningQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemWarning>("warnings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemWarning>(query);
            return this;
        }

        public FulfillmentOrderLineItemQueryBuilder Weight(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("weight");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }
    }
}