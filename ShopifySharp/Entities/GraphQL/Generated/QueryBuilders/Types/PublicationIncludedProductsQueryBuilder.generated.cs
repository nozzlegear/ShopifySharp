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
    public sealed class PublicationIncludedProductsQueryBuilder : FieldsQueryBuilderBase<ProductConnection, PublicationIncludedProductsQueryBuilder>, IHasArguments<PublicationIncludedProductsArgumentsBuilder>
    {
        public PublicationIncludedProductsArgumentsBuilder Arguments { get; }
        protected override PublicationIncludedProductsQueryBuilder Self => this;

        public PublicationIncludedProductsQueryBuilder(string name) : base(new Query<ProductConnection>(name))
        {
            Arguments = new PublicationIncludedProductsArgumentsBuilder(base.InnerQuery);
        }

        public PublicationIncludedProductsQueryBuilder(IQuery<ProductConnection> query) : base(query)
        {
            Arguments = new PublicationIncludedProductsArgumentsBuilder(base.InnerQuery);
        }

        public PublicationIncludedProductsQueryBuilder SetArguments(Action<PublicationIncludedProductsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublicationIncludedProductsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder> build)
        {
            var query = new Query<ProductEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductEdge>(query);
            return this;
        }

        public PublicationIncludedProductsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public PublicationIncludedProductsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}