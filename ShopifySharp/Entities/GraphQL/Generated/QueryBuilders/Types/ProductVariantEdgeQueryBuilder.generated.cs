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

        public ProductVariantEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}