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
    public sealed class MetafieldReferenceCommentsQueryBuilder : FieldsQueryBuilderBase<CommentConnection, MetafieldReferenceCommentsQueryBuilder>, IHasArguments<MetafieldReferenceCommentsArgumentsBuilder>
    {
        public MetafieldReferenceCommentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceCommentsQueryBuilder Self => this;

        public MetafieldReferenceCommentsQueryBuilder(string name) : base(new Query<CommentConnection>(name))
        {
            Arguments = new MetafieldReferenceCommentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceCommentsQueryBuilder(IQuery<CommentConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceCommentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceCommentsQueryBuilder SetArguments(Action<MetafieldReferenceCommentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceCommentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder> build)
        {
            var query = new Query<CommentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentEdge>(query);
            return this;
        }

        public MetafieldReferenceCommentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public MetafieldReferenceCommentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}