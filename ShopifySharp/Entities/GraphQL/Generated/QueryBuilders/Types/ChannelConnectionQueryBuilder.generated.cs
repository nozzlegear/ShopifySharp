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
    public sealed class ChannelConnectionQueryBuilder : FieldsQueryBuilderBase<ChannelConnection, ChannelConnectionQueryBuilder>
    {
        protected override ChannelConnectionQueryBuilder Self => this;

        public ChannelConnectionQueryBuilder() : this("channelConnection")
        {
        }

        public ChannelConnectionQueryBuilder(string name) : base(new Query<ChannelConnection>(name))
        {
        }

        public ChannelConnectionQueryBuilder(IQuery<ChannelConnection> query) : base(query)
        {
        }

        public ChannelConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelEdgeQueryBuilder> build)
        {
            var query = new Query<ChannelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelEdge>(query);
            return this;
        }

        public ChannelConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public ChannelConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}