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
    public sealed class ProductComponentTypeEdgeQueryBuilder : FieldsQueryBuilderBase<ProductComponentTypeEdge, ProductComponentTypeEdgeQueryBuilder>
    {
        protected override ProductComponentTypeEdgeQueryBuilder Self => this;

        public ProductComponentTypeEdgeQueryBuilder() : this("productComponentTypeEdge")
        {
        }

        public ProductComponentTypeEdgeQueryBuilder(string name) : base(new Query<ProductComponentTypeEdge>(name))
        {
        }

        public ProductComponentTypeEdgeQueryBuilder(IQuery<ProductComponentTypeEdge> query) : base(query)
        {
        }

        public ProductComponentTypeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductComponentTypeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductComponentTypeQueryBuilder> build)
        {
            var query = new Query<ProductComponentType>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductComponentTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentType>(query);
            return this;
        }
    }
}