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
    public sealed class ProductPublicationEdgeQueryBuilder : FieldsQueryBuilderBase<ProductPublicationEdge, ProductPublicationEdgeQueryBuilder>
    {
        protected override ProductPublicationEdgeQueryBuilder Self => this;

        public ProductPublicationEdgeQueryBuilder() : this("productPublicationEdge")
        {
        }

        public ProductPublicationEdgeQueryBuilder(string name) : base(new Query<ProductPublicationEdge>(name))
        {
        }

        public ProductPublicationEdgeQueryBuilder(IQuery<ProductPublicationEdge> query) : base(query)
        {
        }

        public ProductPublicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ProductPublicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder> build)
        {
            var query = new Query<ProductPublication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublication>(query);
            return this;
        }
    }
}