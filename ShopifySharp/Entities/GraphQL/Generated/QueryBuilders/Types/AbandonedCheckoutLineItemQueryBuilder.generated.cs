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
    public sealed class AbandonedCheckoutLineItemQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItem, AbandonedCheckoutLineItemQueryBuilder>
    {
        protected override AbandonedCheckoutLineItemQueryBuilder Self => this;

        public AbandonedCheckoutLineItemQueryBuilder() : this("abandonedCheckoutLineItem")
        {
        }

        public AbandonedCheckoutLineItemQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItem>(name))
        {
        }

        public AbandonedCheckoutLineItemQueryBuilder(IQuery<AbandonedCheckoutLineItem> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemComponentQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItemComponent>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItemComponent>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder DiscountAllocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountAllocationConnection>("discountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocationConnection>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder DiscountedTotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder DiscountedTotalPriceWithCodeDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedTotalPriceWithCodeDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder DiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder DiscountedUnitPriceWithCodeDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceWithCodeDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder OriginalTotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalTotalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder ParentRelationship(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemParentRelationshipQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItemParentRelationship>("parentRelationship");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutLineItemParentRelationshipQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItemParentRelationship>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public AbandonedCheckoutLineItemQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }
    }
}