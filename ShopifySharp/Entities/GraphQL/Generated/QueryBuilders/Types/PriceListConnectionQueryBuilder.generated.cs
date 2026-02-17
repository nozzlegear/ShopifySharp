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
    public sealed class PriceListConnectionQueryBuilder : FieldsQueryBuilderBase<PriceListConnection, PriceListConnectionQueryBuilder>
    {
        protected override PriceListConnectionQueryBuilder Self => this;

        public PriceListConnectionQueryBuilder() : this("priceListConnection")
        {
        }

        public PriceListConnectionQueryBuilder(string name) : base(new Query<PriceListConnection>(name))
        {
        }

        public PriceListConnectionQueryBuilder(IQuery<PriceListConnection> query) : base(query)
        {
        }

        public PriceListConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListEdgeQueryBuilder> build)
        {
            var query = new Query<PriceListEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListEdge>(query);
            return this;
        }

        public PriceListConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}