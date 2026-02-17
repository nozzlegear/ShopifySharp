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
    public sealed class PriceListPriceQueryBuilder : FieldsQueryBuilderBase<PriceListPrice, PriceListPriceQueryBuilder>
    {
        protected override PriceListPriceQueryBuilder Self => this;

        public PriceListPriceQueryBuilder() : this("priceListPrice")
        {
        }

        public PriceListPriceQueryBuilder(string name) : base(new Query<PriceListPrice>(name))
        {
        }

        public PriceListPriceQueryBuilder(IQuery<PriceListPrice> query) : base(query)
        {
        }

        public PriceListPriceQueryBuilder CompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("compareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PriceListPriceQueryBuilder OriginType()
        {
            base.InnerQuery.AddField("originType");
            return this;
        }

        public PriceListPriceQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public PriceListPriceQueryBuilder QuantityPriceBreaks(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakConnection>("quantityPriceBreaks");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakConnection>(query);
            return this;
        }

        public PriceListPriceQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}