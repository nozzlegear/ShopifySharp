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
    public sealed class SubscriptionLineQueryBuilder : FieldsQueryBuilderBase<SubscriptionLine, SubscriptionLineQueryBuilder>
    {
        protected override SubscriptionLineQueryBuilder Self => this;

        public SubscriptionLineQueryBuilder() : this("subscriptionLine")
        {
        }

        public SubscriptionLineQueryBuilder(string name) : base(new Query<SubscriptionLine>(name))
        {
        }

        public SubscriptionLineQueryBuilder(IQuery<SubscriptionLine> query) : base(query)
        {
        }

        public SubscriptionLineQueryBuilder ConcatenatedOriginContract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("concatenatedOriginContract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder CurrentPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("currentPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder CustomAttributes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("customAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder DiscountAllocations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDiscountAllocationQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountAllocation>("discountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountAllocation>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionLineQueryBuilder LineDiscountedPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("lineDiscountedPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder PricingPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionPricingPolicyQueryBuilder> build)
        {
            var query = new Query<SubscriptionPricingPolicy>("pricingPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionPricingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionPricingPolicy>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder ProductId()
        {
            base.InnerQuery.AddField("productId");
            return this;
        }

        public SubscriptionLineQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public SubscriptionLineQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public SubscriptionLineQueryBuilder SellingPlanId()
        {
            base.InnerQuery.AddField("sellingPlanId");
            return this;
        }

        public SubscriptionLineQueryBuilder SellingPlanName()
        {
            base.InnerQuery.AddField("sellingPlanName");
            return this;
        }

        public SubscriptionLineQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public SubscriptionLineQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        public SubscriptionLineQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public SubscriptionLineQueryBuilder VariantId()
        {
            base.InnerQuery.AddField("variantId");
            return this;
        }

        public SubscriptionLineQueryBuilder VariantImage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("variantImage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public SubscriptionLineQueryBuilder VariantTitle()
        {
            base.InnerQuery.AddField("variantTitle");
            return this;
        }
    }
}