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
    public sealed class CommentEventEmbedMediaQueryBuilder : FieldsQueryBuilderBase<MediaConnection, CommentEventEmbedMediaQueryBuilder>, IHasArguments<CommentEventEmbedMediaArgumentsBuilder>
    {
        public CommentEventEmbedMediaArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedMediaQueryBuilder Self => this;

        public CommentEventEmbedMediaQueryBuilder(string name) : base(new Query<MediaConnection>(name))
        {
            Arguments = new CommentEventEmbedMediaArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedMediaQueryBuilder(IQuery<MediaConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedMediaArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedMediaQueryBuilder SetArguments(Action<CommentEventEmbedMediaArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedMediaQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder> build)
        {
            var query = new Query<MediaEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaEdge>(query);
            return this;
        }

        public CommentEventEmbedMediaQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public CommentEventEmbedMediaQueryBuilder Nodes(Action<MediaInterfaceCasesBuilder> build)
        {
            var query = new Query<IMedia>("nodes");
            var unionBuilder = new MediaInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}