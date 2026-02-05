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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ProductBundleComponentConnectionQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentConnection, ProductBundleComponentConnectionQueryBuilder>
    {
        protected override ProductBundleComponentConnectionQueryBuilder Self => this;

        public ProductBundleComponentConnectionQueryBuilder() : this("productBundleComponentConnection")
        {
        }

        public ProductBundleComponentConnectionQueryBuilder(string name) : base(new Query<ProductBundleComponentConnection>(name))
        {
        }

        public ProductBundleComponentConnectionQueryBuilder(IQuery<ProductBundleComponentConnection> query) : base(query)
        {
        }

        public ProductBundleComponentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentEdge>(query);
            return this;
        }

        public ProductBundleComponentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponent>(query);
            return this;
        }

        public ProductBundleComponentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}