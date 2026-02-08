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
    public sealed class ProductPublicationConnectionQueryBuilder : FieldsQueryBuilderBase<ProductPublicationConnection, ProductPublicationConnectionQueryBuilder>
    {
        protected override ProductPublicationConnectionQueryBuilder Self => this;

        public ProductPublicationConnectionQueryBuilder() : this("productPublicationConnection")
        {
        }

        public ProductPublicationConnectionQueryBuilder(string name) : base(new Query<ProductPublicationConnection>(name))
        {
        }

        public ProductPublicationConnectionQueryBuilder(IQuery<ProductPublicationConnection> query) : base(query)
        {
        }

        public ProductPublicationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationEdgeQueryBuilder> build)
        {
            var query = new Query<ProductPublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationEdge>(query);
            return this;
        }

        public ProductPublicationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder> build)
        {
            var query = new Query<ProductPublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublication>(query);
            return this;
        }

        public ProductPublicationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}