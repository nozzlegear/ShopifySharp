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
    public sealed class ProductVariantEdgeQueryBuilder : FieldsQueryBuilderBase<ProductVariantEdge, ProductVariantEdgeQueryBuilder>
    {
        protected override ProductVariantEdgeQueryBuilder Self => this;

        public ProductVariantEdgeQueryBuilder() : this("productVariantEdge")
        {
        }

        public ProductVariantEdgeQueryBuilder(string name) : base(new Query<ProductVariantEdge>(name))
        {
        }

        public ProductVariantEdgeQueryBuilder(IQuery<ProductVariantEdge> query) : base(query)
        {
        }

        public ProductVariantEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductVariantEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}