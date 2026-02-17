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
    public sealed class ImageConnectionQueryBuilder : FieldsQueryBuilderBase<ImageConnection, ImageConnectionQueryBuilder>
    {
        protected override ImageConnectionQueryBuilder Self => this;

        public ImageConnectionQueryBuilder() : this("imageConnection")
        {
        }

        public ImageConnectionQueryBuilder(string name) : base(new Query<ImageConnection>(name))
        {
        }

        public ImageConnectionQueryBuilder(IQuery<ImageConnection> query) : base(query)
        {
        }

        public ImageConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder> build)
        {
            var query = new Query<ImageEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageEdge>(query);
            return this;
        }

        public ImageConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ImageConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}