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
    public sealed class ProductVariantComponentEdgeQueryBuilder : FieldsQueryBuilderBase<ProductVariantComponentEdge, ProductVariantComponentEdgeQueryBuilder>
    {
        protected override ProductVariantComponentEdgeQueryBuilder Self => this;

        public ProductVariantComponentEdgeQueryBuilder() : this("productVariantComponentEdge")
        {
        }

        public ProductVariantComponentEdgeQueryBuilder(string name) : base(new Query<ProductVariantComponentEdge>(name))
        {
        }

        public ProductVariantComponentEdgeQueryBuilder(IQuery<ProductVariantComponentEdge> query) : base(query)
        {
        }

        public ProductVariantComponentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductVariantComponentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponent>(query);
            return this;
        }
    }
}