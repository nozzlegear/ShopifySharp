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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MarketsResolvedValuesOperationQueryBuilder : FieldsQueryBuilderBase<MarketsResolvedValues, MarketsResolvedValuesOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketsResolvedValues>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketsResolvedValuesArgumentsBuilder Arguments { get; }
        protected override MarketsResolvedValuesOperationQueryBuilder Self => this;

        public MarketsResolvedValuesOperationQueryBuilder() : this("marketsResolvedValues")
        {
        }

        public MarketsResolvedValuesOperationQueryBuilder(string name) : base(new Query<MarketsResolvedValues>(name))
        {
            Arguments = new MarketsResolvedValuesArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesOperationQueryBuilder(IQuery<MarketsResolvedValues> query) : base(query)
        {
            Arguments = new MarketsResolvedValuesArgumentsBuilder(base.InnerQuery);
        }

        public MarketsResolvedValuesOperationQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder> build)
        {
            var query = new Query<MarketCatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogConnection>(query);
            return this;
        }

        public MarketsResolvedValuesOperationQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public MarketsResolvedValuesOperationQueryBuilder PriceInclusivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResolvedPriceInclusivityQueryBuilder> build)
        {
            var query = new Query<ResolvedPriceInclusivity>("priceInclusivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResolvedPriceInclusivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResolvedPriceInclusivity>(query);
            return this;
        }

        public MarketsResolvedValuesOperationQueryBuilder WebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceConnection>("webPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceConnection>(query);
            return this;
        }
    }
}