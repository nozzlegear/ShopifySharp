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

        public ChannelEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }
    }
}