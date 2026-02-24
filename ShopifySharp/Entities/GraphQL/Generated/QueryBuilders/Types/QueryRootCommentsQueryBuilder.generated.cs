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
    public sealed class QueryRootCommentsQueryBuilder : FieldsQueryBuilderBase<CommentConnection, QueryRootCommentsQueryBuilder>, IHasArguments<QueryRootCommentsArgumentsBuilder>
    {
        public QueryRootCommentsArgumentsBuilder Arguments { get; }
        protected override QueryRootCommentsQueryBuilder Self => this;

        public QueryRootCommentsQueryBuilder(string name) : base(new Query<CommentConnection>(name))
        {
            Arguments = new QueryRootCommentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCommentsQueryBuilder(IQuery<CommentConnection> query) : base(query)
        {
            Arguments = new QueryRootCommentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCommentsQueryBuilder SetArguments(Action<QueryRootCommentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCommentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder> build)
        {
            var query = new Query<CommentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentEdge>(query);
            return this;
        }

        public QueryRootCommentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public QueryRootCommentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}