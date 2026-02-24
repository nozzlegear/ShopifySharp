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
    public sealed class ProductUnpublishedChannelsQueryBuilder : FieldsQueryBuilderBase<ChannelConnection, ProductUnpublishedChannelsQueryBuilder>, IHasArguments<ProductUnpublishedChannelsArgumentsBuilder>
    {
        public ProductUnpublishedChannelsArgumentsBuilder Arguments { get; }
        protected override ProductUnpublishedChannelsQueryBuilder Self => this;

        public ProductUnpublishedChannelsQueryBuilder(string name) : base(new Query<ChannelConnection>(name))
        {
            Arguments = new ProductUnpublishedChannelsArgumentsBuilder(base.InnerQuery);
        }

        public ProductUnpublishedChannelsQueryBuilder(IQuery<ChannelConnection> query) : base(query)
        {
            Arguments = new ProductUnpublishedChannelsArgumentsBuilder(base.InnerQuery);
        }

        public ProductUnpublishedChannelsQueryBuilder SetArguments(Action<ProductUnpublishedChannelsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductUnpublishedChannelsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelEdgeQueryBuilder> build)
        {
            var query = new Query<ChannelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelEdge>(query);
            return this;
        }

        public ProductUnpublishedChannelsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public ProductUnpublishedChannelsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}