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
    public sealed class CommentEventEmbedUnpublishedPublicationsQueryBuilder : FieldsQueryBuilderBase<PublicationConnection, CommentEventEmbedUnpublishedPublicationsQueryBuilder>, IHasArguments<CommentEventEmbedUnpublishedPublicationsArgumentsBuilder>
    {
        public CommentEventEmbedUnpublishedPublicationsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedUnpublishedPublicationsQueryBuilder Self => this;

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder(string name) : base(new Query<PublicationConnection>(name))
        {
            Arguments = new CommentEventEmbedUnpublishedPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder(IQuery<PublicationConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedUnpublishedPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder SetArguments(Action<CommentEventEmbedUnpublishedPublicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationEdgeQueryBuilder> build)
        {
            var query = new Query<PublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationEdge>(query);
            return this;
        }

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CommentEventEmbedUnpublishedPublicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}