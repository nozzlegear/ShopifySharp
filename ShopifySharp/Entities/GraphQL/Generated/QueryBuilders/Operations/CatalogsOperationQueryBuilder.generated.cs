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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CatalogsOperationQueryBuilder : FieldsQueryBuilderBase<CatalogConnection, CatalogsOperationQueryBuilder>, IGraphOperationQueryBuilder<CatalogConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CatalogsArgumentsBuilder Arguments { get; }
        protected override CatalogsOperationQueryBuilder Self => this;

        public CatalogsOperationQueryBuilder() : this("catalogs")
        {
        }

        public CatalogsOperationQueryBuilder(string name) : base(new Query<CatalogConnection>(name))
        {
            Arguments = new CatalogsArgumentsBuilder(base.InnerQuery);
        }

        public CatalogsOperationQueryBuilder(IQuery<CatalogConnection> query) : base(query)
        {
            Arguments = new CatalogsArgumentsBuilder(base.InnerQuery);
        }

        public CatalogsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogEdgeQueryBuilder> build)
        {
            var query = new Query<CatalogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogEdge>(query);
            return this;
        }

        public CatalogsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder> build)
        {
            var query = new Query<ICatalog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICatalog>(query);
            return this;
        }

        public CatalogsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}