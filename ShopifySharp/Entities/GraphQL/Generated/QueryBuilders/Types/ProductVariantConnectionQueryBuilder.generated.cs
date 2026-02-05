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
    public sealed class ProductVariantConnectionQueryBuilder : FieldsQueryBuilderBase<ProductVariantConnection, ProductVariantConnectionQueryBuilder>
    {
        protected override ProductVariantConnectionQueryBuilder Self => this;

        public ProductVariantConnectionQueryBuilder() : this("productVariantConnection")
        {
        }

        public ProductVariantConnectionQueryBuilder(string name) : base(new Query<ProductVariantConnection>(name))
        {
        }

        public ProductVariantConnectionQueryBuilder(IQuery<ProductVariantConnection> query) : base(query)
        {
        }

        public ProductVariantConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantEdge>(query);
            return this;
        }

        public ProductVariantConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}