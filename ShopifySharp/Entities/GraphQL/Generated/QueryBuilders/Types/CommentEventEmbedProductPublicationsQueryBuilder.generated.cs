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
    public sealed class CommentEventEmbedProductPublicationsQueryBuilder : FieldsQueryBuilderBase<ProductPublicationConnection, CommentEventEmbedProductPublicationsQueryBuilder>, IHasArguments<CommentEventEmbedProductPublicationsArgumentsBuilder>
    {
        public CommentEventEmbedProductPublicationsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedProductPublicationsQueryBuilder Self => this;

        public CommentEventEmbedProductPublicationsQueryBuilder(string name) : base(new Query<ProductPublicationConnection>(name))
        {
            Arguments = new CommentEventEmbedProductPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedProductPublicationsQueryBuilder(IQuery<ProductPublicationConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedProductPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedProductPublicationsQueryBuilder SetArguments(Action<CommentEventEmbedProductPublicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedProductPublicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationEdgeQueryBuilder> build)
        {
            var query = new Query<ProductPublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationEdge>(query);
            return this;
        }

        public CommentEventEmbedProductPublicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationQueryBuilder> build)
        {
            var query = new Query<ProductPublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublication>(query);
            return this;
        }

        public CommentEventEmbedProductPublicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}