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
    public sealed class CatalogConnectionQueryBuilder : FieldsQueryBuilderBase<CatalogConnection, CatalogConnectionQueryBuilder>
    {
        protected override CatalogConnectionQueryBuilder Self => this;

        public CatalogConnectionQueryBuilder() : this("catalogConnection")
        {
        }

        public CatalogConnectionQueryBuilder(string name) : base(new Query<CatalogConnection>(name))
        {
        }

        public CatalogConnectionQueryBuilder(IQuery<CatalogConnection> query) : base(query)
        {
        }

        public CatalogConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder> build)
        {
            var query = new Query<CatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogEdge>(query);
            return this;
        }

        public CatalogConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}