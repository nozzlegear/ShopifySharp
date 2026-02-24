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
    public sealed class MetafieldReferencerCommentsQueryBuilder : FieldsQueryBuilderBase<CommentConnection, MetafieldReferencerCommentsQueryBuilder>, IHasArguments<MetafieldReferencerCommentsArgumentsBuilder>
    {
        public MetafieldReferencerCommentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerCommentsQueryBuilder Self => this;

        public MetafieldReferencerCommentsQueryBuilder(string name) : base(new Query<CommentConnection>(name))
        {
            Arguments = new MetafieldReferencerCommentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCommentsQueryBuilder(IQuery<CommentConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerCommentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerCommentsQueryBuilder SetArguments(Action<MetafieldReferencerCommentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerCommentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder> build)
        {
            var query = new Query<CommentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentEdge>(query);
            return this;
        }

        public MetafieldReferencerCommentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Comment>(query);
            return this;
        }

        public MetafieldReferencerCommentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}