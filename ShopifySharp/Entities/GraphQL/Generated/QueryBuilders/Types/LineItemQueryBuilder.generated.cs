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
    public sealed class LineItemQueryBuilder : FieldsQueryBuilderBase<LineItem, LineItemQueryBuilder>
    {
        protected override LineItemQueryBuilder Self => this;

        public LineItemQueryBuilder() : this("lineItem")
        {
        }

        public LineItemQueryBuilder(string name) : base(new Query<LineItem>(name))
        {
        }

        public LineItemQueryBuilder(IQuery<LineItem> query) : base(query)
        {
        }

        [Obsolete("Use `restockable` instead.")]
        public LineItemQueryBuilder CanRestock()
        {
            base.InnerQuery.AddField("canRestock");
            return this;
        }

        public LineItemQueryBuilder Contract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public LineItemQueryBuilder CurrentQuantity()
        {
            base.InnerQuery.AddField("currentQuantity");
            return this;
        }

        public LineItemQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public LineItemQueryBuilder DiscountAllocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DiscountAllocation>("discountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocation>(query);
            return this;
        }

        [Obsolete("Use `discountedTotalSet` instead.")]
        public LineItemQueryBuilder DiscountedTotal()
        {
            base.InnerQuery.AddField("discountedTotal");
            return this;
        }

        public LineItemQueryBuilder DiscountedTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `discountedUnitPriceSet` instead.")]
        public LineItemQueryBuilder DiscountedUnitPrice()
        {
            base.InnerQuery.AddField("discountedUnitPrice");
            return this;
        }

        public LineItemQueryBuilder DiscountedUnitPriceAfterAllDiscountsSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceAfterAllDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public LineItemQueryBuilder DiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public LineItemQueryBuilder Duties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder> build)
        {
            var query = new Query<Duty>("duties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Duty>(query);
            return this;
        }

        [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead.")]
        public LineItemQueryBuilder FulfillableQuantity()
        {
            base.InnerQuery.AddField("fulfillableQuantity");
            return this;
        }

        public LineItemQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead")]
        public LineItemQueryBuilder FulfillmentStatus()
        {
            base.InnerQuery.AddField("fulfillmentStatus");
            return this;
        }

        public LineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public LineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public LineItemQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public LineItemQueryBuilder LineItemGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemGroupQueryBuilder> build)
        {
            var query = new Query<LineItemGroup>("lineItemGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemGroup>(query);
            return this;
        }

        public LineItemQueryBuilder MerchantEditable()
        {
            base.InnerQuery.AddField("merchantEditable");
            return this;
        }

        public LineItemQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public LineItemQueryBuilder NonFulfillableQuantity()
        {
            base.InnerQuery.AddField("nonFulfillableQuantity");
            return this;
        }

        [Obsolete("Use `originalTotalSet` instead.")]
        public LineItemQueryBuilder OriginalTotal()
        {
            base.InnerQuery.AddField("originalTotal");
            return this;
        }

        public LineItemQueryBuilder OriginalTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `originalUnitPriceSet` instead.")]
        public LineItemQueryBuilder OriginalUnitPrice()
        {
            base.InnerQuery.AddField("originalUnitPrice");
            return this;
        }

        public LineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public LineItemQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public LineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public LineItemQueryBuilder RefundableQuantity()
        {
            base.InnerQuery.AddField("refundableQuantity");
            return this;
        }

        public LineItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public LineItemQueryBuilder Restockable()
        {
            base.InnerQuery.AddField("restockable");
            return this;
        }

        public LineItemQueryBuilder SellingPlan(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemSellingPlanQueryBuilder> build)
        {
            var query = new Query<LineItemSellingPlan>("sellingPlan");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemSellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItemSellingPlan>(query);
            return this;
        }

        public LineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public LineItemQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public LineItemQueryBuilder SuggestedReturnReasonDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionConnection>("suggestedReturnReasonDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionConnection>(query);
            return this;
        }

        public LineItemQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        public LineItemQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public LineItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        [Obsolete("Use `totalDiscountSet` instead.")]
        public LineItemQueryBuilder TotalDiscount()
        {
            base.InnerQuery.AddField("totalDiscount");
            return this;
        }

        public LineItemQueryBuilder TotalDiscountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `unfulfilledDiscountedTotalSet` instead.")]
        public LineItemQueryBuilder UnfulfilledDiscountedTotal()
        {
            base.InnerQuery.AddField("unfulfilledDiscountedTotal");
            return this;
        }

        public LineItemQueryBuilder UnfulfilledDiscountedTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("unfulfilledDiscountedTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `unfulfilledOriginalTotalSet` instead.")]
        public LineItemQueryBuilder UnfulfilledOriginalTotal()
        {
            base.InnerQuery.AddField("unfulfilledOriginalTotal");
            return this;
        }

        public LineItemQueryBuilder UnfulfilledOriginalTotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("unfulfilledOriginalTotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public LineItemQueryBuilder UnfulfilledQuantity()
        {
            base.InnerQuery.AddField("unfulfilledQuantity");
            return this;
        }

        public LineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public LineItemQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }

        public LineItemQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }
    }
}