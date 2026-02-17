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
    public sealed class CalculatedExchangeLineItemQueryBuilder : FieldsQueryBuilderBase<CalculatedExchangeLineItem, CalculatedExchangeLineItemQueryBuilder>
    {
        protected override CalculatedExchangeLineItemQueryBuilder Self => this;

        public CalculatedExchangeLineItemQueryBuilder() : this("calculatedExchangeLineItem")
        {
        }

        public CalculatedExchangeLineItemQueryBuilder(string name) : base(new Query<CalculatedExchangeLineItem>(name))
        {
        }

        public CalculatedExchangeLineItemQueryBuilder(IQuery<CalculatedExchangeLineItem> query) : base(query)
        {
        }

        public CalculatedExchangeLineItemQueryBuilder CalculatedDiscountAllocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountAllocationQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountAllocation>("calculatedDiscountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDiscountAllocation>(query);
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder DiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder SubtotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedExchangeLineItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}