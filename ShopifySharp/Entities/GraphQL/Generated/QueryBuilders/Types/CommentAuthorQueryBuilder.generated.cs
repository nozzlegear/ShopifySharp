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
    public sealed class CommentAuthorQueryBuilder : FieldsQueryBuilderBase<CommentAuthor, CommentAuthorQueryBuilder>
    {
        protected override CommentAuthorQueryBuilder Self => this;

        public CommentAuthorQueryBuilder() : this("commentAuthor")
        {
        }

        public CommentAuthorQueryBuilder(string name) : base(new Query<CommentAuthor>(name))
        {
        }

        public CommentAuthorQueryBuilder(IQuery<CommentAuthor> query) : base(query)
        {
        }

        public CommentAuthorQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public CommentAuthorQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}