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
    public sealed class ProductVariantPricePairEdgeQueryBuilder : FieldsQueryBuilderBase<ProductVariantPricePairEdge, ProductVariantPricePairEdgeQueryBuilder>
    {
        protected override ProductVariantPricePairEdgeQueryBuilder Self => this;

        public ProductVariantPricePairEdgeQueryBuilder() : this("productVariantPricePairEdge")
        {
        }

        public ProductVariantPricePairEdgeQueryBuilder(string name) : base(new Query<ProductVariantPricePairEdge>(name))
        {
        }

        public ProductVariantPricePairEdgeQueryBuilder(IQuery<ProductVariantPricePairEdge> query) : base(query)
        {
        }

        public ProductVariantPricePairEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductVariantPricePairEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePair>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePair>(query);
            return this;
        }
    }
}