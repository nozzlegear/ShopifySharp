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
    public sealed class MarketsResolvedValuesQueryBuilder : FieldsQueryBuilderBase<MarketsResolvedValues, MarketsResolvedValuesQueryBuilder>
    {
        protected override MarketsResolvedValuesQueryBuilder Self => this;

        public MarketsResolvedValuesQueryBuilder() : this("marketsResolvedValues")
        {
        }

        public MarketsResolvedValuesQueryBuilder(string name) : base(new Query<MarketsResolvedValues>(name))
        {
        }

        public MarketsResolvedValuesQueryBuilder(IQuery<MarketsResolvedValues> query) : base(query)
        {
        }

        public MarketsResolvedValuesQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder> build)
        {
            var query = new Query<MarketCatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogConnection>(query);
            return this;
        }

        public MarketsResolvedValuesQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public MarketsResolvedValuesQueryBuilder PriceInclusivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResolvedPriceInclusivityQueryBuilder> build)
        {
            var query = new Query<ResolvedPriceInclusivity>("priceInclusivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResolvedPriceInclusivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResolvedPriceInclusivity>(query);
            return this;
        }

        public MarketsResolvedValuesQueryBuilder WebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceConnection>("webPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceConnection>(query);
            return this;
        }
    }
}