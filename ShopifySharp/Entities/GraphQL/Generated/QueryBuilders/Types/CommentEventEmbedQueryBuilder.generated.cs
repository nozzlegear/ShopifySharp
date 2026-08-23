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
    public sealed class CommentEventEmbedQueryBuilder : FieldsQueryBuilderBase<CommentEventEmbed, CommentEventEmbedQueryBuilder>
    {
        protected override CommentEventEmbedQueryBuilder Self => this;

        public CommentEventEmbedQueryBuilder() : this("commentEventEmbed")
        {
        }

        public CommentEventEmbedQueryBuilder(string name) : base(new Query<CommentEventEmbed>(name))
        {
        }

        public CommentEventEmbedQueryBuilder(IQuery<CommentEventEmbed> query) : base(query)
        {
        }

        public CommentEventEmbedQueryBuilder CommentEventEmbed(Action<CommentEventEmbedUnionCasesBuilder> build)
        {
            var query = new Query<CommentEventEmbed>("commentEventEmbed");
            var unionBuilder = new CommentEventEmbedUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}