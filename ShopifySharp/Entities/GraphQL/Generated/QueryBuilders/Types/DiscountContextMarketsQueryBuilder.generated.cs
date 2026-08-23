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
    public sealed class DiscountContextMarketsQueryBuilder : FieldsQueryBuilderBase<MarketConnection, DiscountContextMarketsQueryBuilder>, IHasArguments<DiscountContextMarketsArgumentsBuilder>
    {
        public DiscountContextMarketsArgumentsBuilder Arguments { get; }
        protected override DiscountContextMarketsQueryBuilder Self => this;

        public DiscountContextMarketsQueryBuilder(string name) : base(new Query<MarketConnection>(name))
        {
            Arguments = new DiscountContextMarketsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountContextMarketsQueryBuilder(IQuery<MarketConnection> query) : base(query)
        {
            Arguments = new DiscountContextMarketsArgumentsBuilder(base.InnerQuery);
        }

        public DiscountContextMarketsQueryBuilder SetArguments(Action<DiscountContextMarketsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountContextMarketsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder> build)
        {
            var query = new Query<MarketEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketEdge>(query);
            return this;
        }

        public DiscountContextMarketsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public DiscountContextMarketsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}