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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DraftOrderLineItemQueryBuilder : FieldsQueryBuilderBase<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>
    {
        protected override DraftOrderLineItemQueryBuilder Self => this;

        public DraftOrderLineItemQueryBuilder() : this("draftOrderLineItem")
        {
        }

        public DraftOrderLineItemQueryBuilder(string name) : base(new Query<DraftOrderLineItem>(name))
        {
        }

        public DraftOrderLineItemQueryBuilder(IQuery<DraftOrderLineItem> query) : base(query)
        {
        }

        public DraftOrderLineItemQueryBuilder AppliedDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder> build)
        {
            var query = new Query<DraftOrderAppliedDiscount>("appliedDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderAppliedDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderAppliedDiscount>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder ApproximateDiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("approximateDiscountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder BundleComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("bundleComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Custom()
        {
            base.InnerQuery.AddField("custom");
            return this;
        }

        public DraftOrderLineItemQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder CustomAttributesV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TypedAttributeQueryBuilder> build)
        {
            var query = new Query<TypedAttribute>("customAttributesV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TypedAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TypedAttribute>(query);
            return this;
        }

        [Obsolete("Use `discountedTotalSet` instead.")]
        public DraftOrderLineItemQueryBuilder DiscountedTotal()
        {
            base.InnerQuery.AddField("discountedTotal");
            return this;
        }

        public DraftOrderLineItemQueryBuilder DiscountedTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
        public DraftOrderLineItemQueryBuilder DiscountedUnitPrice()
        {
            base.InnerQuery.AddField("discountedUnitPrice");
            return this;
        }

        public DraftOrderLineItemQueryBuilder DiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        [Obsolete("Use `weight` instead.")]
        public DraftOrderLineItemQueryBuilder Grams()
        {
            base.InnerQuery.AddField("grams");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        [Obsolete("Use `originalTotalSet` instead.")]
        public DraftOrderLineItemQueryBuilder OriginalTotal()
        {
            base.InnerQuery.AddField("originalTotal");
            return this;
        }

        public DraftOrderLineItemQueryBuilder OriginalTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `originalUnitPriceWithCurrency` instead.")]
        public DraftOrderLineItemQueryBuilder OriginalUnitPrice()
        {
            base.InnerQuery.AddField("originalUnitPrice");
            return this;
        }

        public DraftOrderLineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder OriginalUnitPriceWithCurrency(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalUnitPriceWithCurrency");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder PriceOverride(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("priceOverride");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public DraftOrderLineItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        public DraftOrderLineItemQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        [Obsolete("Use `totalDiscountSet` instead.")]
        public DraftOrderLineItemQueryBuilder TotalDiscount()
        {
            base.InnerQuery.AddField("totalDiscount");
            return this;
        }

        public DraftOrderLineItemQueryBuilder TotalDiscountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder Uuid()
        {
            base.InnerQuery.AddField("uuid");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public DraftOrderLineItemQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }

        public DraftOrderLineItemQueryBuilder Weight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("weight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }
    }
}