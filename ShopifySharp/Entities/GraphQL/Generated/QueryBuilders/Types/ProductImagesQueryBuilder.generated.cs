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
    public sealed class ProductImagesQueryBuilder : FieldsQueryBuilderBase<ImageConnection, ProductImagesQueryBuilder>, IHasArguments<ProductImagesArgumentsBuilder>
    {
        public ProductImagesArgumentsBuilder Arguments { get; }
        protected override ProductImagesQueryBuilder Self => this;

        public ProductImagesQueryBuilder(string name) : base(new Query<ImageConnection>(name))
        {
            Arguments = new ProductImagesArgumentsBuilder(base.InnerQuery);
        }

        public ProductImagesQueryBuilder(IQuery<ImageConnection> query) : base(query)
        {
            Arguments = new ProductImagesArgumentsBuilder(base.InnerQuery);
        }

        public ProductImagesQueryBuilder SetArguments(Action<ProductImagesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductImagesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder> build)
        {
            var query = new Query<ImageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageEdge>(query);
            return this;
        }

        public ProductImagesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ProductImagesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}