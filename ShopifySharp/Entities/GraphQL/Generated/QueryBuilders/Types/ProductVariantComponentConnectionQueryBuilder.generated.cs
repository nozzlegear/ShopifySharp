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
    public sealed class ProductVariantComponentConnectionQueryBuilder : FieldsQueryBuilderBase<ProductVariantComponentConnection, ProductVariantComponentConnectionQueryBuilder>
    {
        protected override ProductVariantComponentConnectionQueryBuilder Self => this;

        public ProductVariantComponentConnectionQueryBuilder() : this("productVariantComponentConnection")
        {
        }

        public ProductVariantComponentConnectionQueryBuilder(string name) : base(new Query<ProductVariantComponentConnection>(name))
        {
        }

        public ProductVariantComponentConnectionQueryBuilder(IQuery<ProductVariantComponentConnection> query) : base(query)
        {
        }

        public ProductVariantComponentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentEdge>(query);
            return this;
        }

        public ProductVariantComponentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponent>(query);
            return this;
        }

        public ProductVariantComponentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}