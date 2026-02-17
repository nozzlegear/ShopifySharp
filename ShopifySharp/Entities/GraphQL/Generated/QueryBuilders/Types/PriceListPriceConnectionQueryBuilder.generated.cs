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
    public sealed class PriceListPriceConnectionQueryBuilder : FieldsQueryBuilderBase<PriceListPriceConnection, PriceListPriceConnectionQueryBuilder>
    {
        protected override PriceListPriceConnectionQueryBuilder Self => this;

        public PriceListPriceConnectionQueryBuilder() : this("priceListPriceConnection")
        {
        }

        public PriceListPriceConnectionQueryBuilder(string name) : base(new Query<PriceListPriceConnection>(name))
        {
        }

        public PriceListPriceConnectionQueryBuilder(IQuery<PriceListPriceConnection> query) : base(query)
        {
        }

        public PriceListPriceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceEdgeQueryBuilder> build)
        {
            var query = new Query<PriceListPriceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceEdge>(query);
            return this;
        }

        public PriceListPriceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListPriceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}