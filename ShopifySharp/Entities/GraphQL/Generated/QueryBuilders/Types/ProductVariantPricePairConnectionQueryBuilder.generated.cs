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
    public sealed class ProductVariantPricePairConnectionQueryBuilder : FieldsQueryBuilderBase<ProductVariantPricePairConnection, ProductVariantPricePairConnectionQueryBuilder>
    {
        protected override ProductVariantPricePairConnectionQueryBuilder Self => this;

        public ProductVariantPricePairConnectionQueryBuilder() : this("productVariantPricePairConnection")
        {
        }

        public ProductVariantPricePairConnectionQueryBuilder(string name) : base(new Query<ProductVariantPricePairConnection>(name))
        {
        }

        public ProductVariantPricePairConnectionQueryBuilder(IQuery<ProductVariantPricePairConnection> query) : base(query)
        {
        }

        public ProductVariantPricePairConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairEdge>(query);
            return this;
        }

        public ProductVariantPricePairConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePair>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePair>(query);
            return this;
        }

        public ProductVariantPricePairConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}