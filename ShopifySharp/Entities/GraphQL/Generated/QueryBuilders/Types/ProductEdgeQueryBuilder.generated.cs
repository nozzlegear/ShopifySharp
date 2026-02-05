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
    public sealed class ProductEdgeQueryBuilder : FieldsQueryBuilderBase<ProductEdge, ProductEdgeQueryBuilder>
    {
        protected override ProductEdgeQueryBuilder Self => this;

        public ProductEdgeQueryBuilder() : this("productEdge")
        {
        }

        public ProductEdgeQueryBuilder(string name) : base(new Query<ProductEdge>(name))
        {
        }

        public ProductEdgeQueryBuilder(IQuery<ProductEdge> query) : base(query)
        {
        }

        public ProductEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }
    }
}