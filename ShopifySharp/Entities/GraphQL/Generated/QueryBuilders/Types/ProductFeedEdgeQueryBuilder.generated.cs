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
    public sealed class ProductFeedEdgeQueryBuilder : FieldsQueryBuilderBase<ProductFeedEdge, ProductFeedEdgeQueryBuilder>
    {
        protected override ProductFeedEdgeQueryBuilder Self => this;

        public ProductFeedEdgeQueryBuilder() : this("productFeedEdge")
        {
        }

        public ProductFeedEdgeQueryBuilder(string name) : base(new Query<ProductFeedEdge>(name))
        {
        }

        public ProductFeedEdgeQueryBuilder(IQuery<ProductFeedEdge> query) : base(query)
        {
        }

        public ProductFeedEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductFeedEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }
    }
}