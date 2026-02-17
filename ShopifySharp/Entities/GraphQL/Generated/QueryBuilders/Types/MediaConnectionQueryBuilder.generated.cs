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
    public sealed class MediaConnectionQueryBuilder : FieldsQueryBuilderBase<MediaConnection, MediaConnectionQueryBuilder>
    {
        protected override MediaConnectionQueryBuilder Self => this;

        public MediaConnectionQueryBuilder() : this("mediaConnection")
        {
        }

        public MediaConnectionQueryBuilder(string name) : base(new Query<MediaConnection>(name))
        {
        }

        public MediaConnectionQueryBuilder(IQuery<MediaConnection> query) : base(query)
        {
        }

        public MediaConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder> build)
        {
            var query = new Query<MediaEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaEdge>(query);
            return this;
        }

        public MediaConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public MediaConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}