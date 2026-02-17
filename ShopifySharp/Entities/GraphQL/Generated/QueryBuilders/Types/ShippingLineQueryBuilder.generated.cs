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
    public sealed class ShippingLineQueryBuilder : FieldsQueryBuilderBase<ShippingLine, ShippingLineQueryBuilder>
    {
        protected override ShippingLineQueryBuilder Self => this;

        public ShippingLineQueryBuilder() : this("shippingLine")
        {
        }

        public ShippingLineQueryBuilder(string name) : base(new Query<ShippingLine>(name))
        {
        }

        public ShippingLineQueryBuilder(IQuery<ShippingLine> query) : base(query)
        {
        }

        public ShippingLineQueryBuilder CarrierIdentifier()
        {
            base.InnerQuery.AddField("carrierIdentifier");
            return this;
        }

        public ShippingLineQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShippingLineQueryBuilder CurrentDiscountedPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("currentDiscountedPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ShippingLineQueryBuilder Custom()
        {
            base.InnerQuery.AddField("custom");
            return this;
        }

        public ShippingLineQueryBuilder DeliveryCategory()
        {
            base.InnerQuery.AddField("deliveryCategory");
            return this;
        }

        public ShippingLineQueryBuilder DiscountAllocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DiscountAllocation>("discountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocation>(query);
            return this;
        }

        public ShippingLineQueryBuilder DiscountedPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("discountedPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShippingLineQueryBuilder DiscountedPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ShippingLineQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShippingLineQueryBuilder IsRemoved()
        {
            base.InnerQuery.AddField("isRemoved");
            return this;
        }

        public ShippingLineQueryBuilder OriginalPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShippingLineQueryBuilder OriginalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ShippingLineQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        [Obsolete("Use `originalPriceSet` instead.")]
        public ShippingLineQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public ShippingLineQueryBuilder RequestedFulfillmentService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("requestedFulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public ShippingLineQueryBuilder ShippingRateHandle()
        {
            base.InnerQuery.AddField("shippingRateHandle");
            return this;
        }

        public ShippingLineQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public ShippingLineQueryBuilder TaxLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder> build)
        {
            var query = new Query<TaxLine>("taxLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxLine>(query);
            return this;
        }

        public ShippingLineQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}