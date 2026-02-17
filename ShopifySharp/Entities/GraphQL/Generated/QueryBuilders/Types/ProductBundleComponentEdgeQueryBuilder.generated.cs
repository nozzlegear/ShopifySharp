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
    public sealed class ProductBundleComponentEdgeQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentEdge, ProductBundleComponentEdgeQueryBuilder>
    {
        protected override ProductBundleComponentEdgeQueryBuilder Self => this;

        public ProductBundleComponentEdgeQueryBuilder() : this("productBundleComponentEdge")
        {
        }

        public ProductBundleComponentEdgeQueryBuilder(string name) : base(new Query<ProductBundleComponentEdge>(name))
        {
        }

        public ProductBundleComponentEdgeQueryBuilder(IQuery<ProductBundleComponentEdge> query) : base(query)
        {
        }

        public ProductBundleComponentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductBundleComponentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponent>(query);
            return this;
        }
    }
}