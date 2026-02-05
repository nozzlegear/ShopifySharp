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
    public sealed class QuantityPriceBreakQueryBuilder : FieldsQueryBuilderBase<QuantityPriceBreak, QuantityPriceBreakQueryBuilder>
    {
        protected override QuantityPriceBreakQueryBuilder Self => this;

        public QuantityPriceBreakQueryBuilder() : this("quantityPriceBreak")
        {
        }

        public QuantityPriceBreakQueryBuilder(string name) : base(new Query<QuantityPriceBreak>(name))
        {
        }

        public QuantityPriceBreakQueryBuilder(IQuery<QuantityPriceBreak> query) : base(query)
        {
        }

        public QuantityPriceBreakQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QuantityPriceBreakQueryBuilder MinimumQuantity()
        {
            base.InnerQuery.AddField("minimumQuantity");
            return this;
        }

        public QuantityPriceBreakQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QuantityPriceBreakQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public QuantityPriceBreakQueryBuilder Variant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}