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
    public sealed class PriceListPricesQueryBuilder : FieldsQueryBuilderBase<PriceListPriceConnection, PriceListPricesQueryBuilder>, IHasArguments<PriceListPricesArgumentsBuilder>
    {
        public PriceListPricesArgumentsBuilder Arguments { get; }
        protected override PriceListPricesQueryBuilder Self => this;

        public PriceListPricesQueryBuilder(string name) : base(new Query<PriceListPriceConnection>(name))
        {
            Arguments = new PriceListPricesArgumentsBuilder(base.InnerQuery);
        }

        public PriceListPricesQueryBuilder(IQuery<PriceListPriceConnection> query) : base(query)
        {
            Arguments = new PriceListPricesArgumentsBuilder(base.InnerQuery);
        }

        public PriceListPricesQueryBuilder SetArguments(Action<PriceListPricesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceListPricesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceEdgeQueryBuilder> build)
        {
            var query = new Query<PriceListPriceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceEdge>(query);
            return this;
        }

        public PriceListPricesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListPricesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}