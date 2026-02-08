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
    public sealed class CalculatedDraftOrderLineItemQueryBuilder : FieldsQueryBuilderBase<CalculatedDraftOrderLineItem, CalculatedDraftOrderLineItemQueryBuilder>
    {
        protected override CalculatedDraftOrderLineItemQueryBuilder Self => this;

        public CalculatedDraftOrderLineItemQueryBuilder() : this("calculatedDraftOrderLineItem")
        {
        }

        public CalculatedDraftOrderLineItemQueryBuilder(string name) : base(new Query<CalculatedDraftOrderLineItem>(name))
        {
        }

        public CalculatedDraftOrderLineItemQueryBuilder(IQuery<CalculatedDraftOrderLineItem> query) : base(query)
        {
        }

        public CalculatedDraftOrderLineItemQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderAppliedDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAppliedDiscount>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder ApproximateDiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("approximateDiscountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder BundleComponents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrderLineItem>("bundleComponents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDraftOrderLineItem>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Components(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrderLineItem>("components");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDraftOrderLineItem>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Custom()
        {
            base.InnerQuery.AddField("custom");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder CustomAttributesV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TypedAttributeQueryBuilder> build)
        {
            var query = new Query<TypedAttribute>("customAttributesV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TypedAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TypedAttribute>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder DiscountedTotal(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("discountedTotal");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder DiscountedTotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder DiscountedUnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("discountedUnitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder DiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder OriginalTotal(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalTotal");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder OriginalTotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder OriginalUnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalUnitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder OriginalUnitPriceWithCurrency(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalUnitPriceWithCurrency");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder PriceOverride(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("priceOverride");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder TotalDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder TotalDiscountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Uuid()
        {
            base.InnerQuery.AddField("uuid");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }

        public CalculatedDraftOrderLineItemQueryBuilder Weight(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("weight");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }
    }
}