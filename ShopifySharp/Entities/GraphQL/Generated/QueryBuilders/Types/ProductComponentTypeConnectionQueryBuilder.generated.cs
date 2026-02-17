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
    public sealed class ProductComponentTypeConnectionQueryBuilder : FieldsQueryBuilderBase<ProductComponentTypeConnection, ProductComponentTypeConnectionQueryBuilder>
    {
        protected override ProductComponentTypeConnectionQueryBuilder Self => this;

        public ProductComponentTypeConnectionQueryBuilder() : this("productComponentTypeConnection")
        {
        }

        public ProductComponentTypeConnectionQueryBuilder(string name) : base(new Query<ProductComponentTypeConnection>(name))
        {
        }

        public ProductComponentTypeConnectionQueryBuilder(IQuery<ProductComponentTypeConnection> query) : base(query)
        {
        }

        public ProductComponentTypeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeEdgeQueryBuilder> build)
        {
            var query = new Query<ProductComponentTypeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentTypeEdge>(query);
            return this;
        }

        public ProductComponentTypeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeQueryBuilder> build)
        {
            var query = new Query<ProductComponentType>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentType>(query);
            return this;
        }

        public ProductComponentTypeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}