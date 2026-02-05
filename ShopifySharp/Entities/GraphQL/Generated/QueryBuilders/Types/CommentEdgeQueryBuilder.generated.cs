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
    public sealed class CommentEdgeQueryBuilder : FieldsQueryBuilderBase<CommentEdge, CommentEdgeQueryBuilder>
    {
        protected override CommentEdgeQueryBuilder Self => this;

        public CommentEdgeQueryBuilder() : this("commentEdge")
        {
        }

        public CommentEdgeQueryBuilder(string name) : base(new Query<CommentEdge>(name))
        {
        }

        public CommentEdgeQueryBuilder(IQuery<CommentEdge> query) : base(query)
        {
        }

        public CommentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CommentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }
    }
}