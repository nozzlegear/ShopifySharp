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
    public sealed class ChannelEdgeQueryBuilder : FieldsQueryBuilderBase<ChannelEdge, ChannelEdgeQueryBuilder>
    {
        protected override ChannelEdgeQueryBuilder Self => this;

        public ChannelEdgeQueryBuilder() : this("channelEdge")
        {
        }

        public ChannelEdgeQueryBuilder(string name) : base(new Query<ChannelEdge>(name))
        {
        }

        public ChannelEdgeQueryBuilder(IQuery<ChannelEdge> query) : base(query)
        {
        }

        public ChannelEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ChannelEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }
    }
}