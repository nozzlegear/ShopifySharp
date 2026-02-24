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
    public sealed class MarketCatalogMarketsCountQueryBuilder : FieldsQueryBuilderBase<Count, MarketCatalogMarketsCountQueryBuilder>, IHasArguments<MarketCatalogMarketsCountArgumentsBuilder>
    {
        public MarketCatalogMarketsCountArgumentsBuilder Arguments { get; }
        protected override MarketCatalogMarketsCountQueryBuilder Self => this;

        public MarketCatalogMarketsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new MarketCatalogMarketsCountArgumentsBuilder(base.InnerQuery);
        }

        public MarketCatalogMarketsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new MarketCatalogMarketsCountArgumentsBuilder(base.InnerQuery);
        }

        public MarketCatalogMarketsCountQueryBuilder SetArguments(Action<MarketCatalogMarketsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketCatalogMarketsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public MarketCatalogMarketsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}