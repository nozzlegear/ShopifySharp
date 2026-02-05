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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CommentNotSpamArgumentsBuilder : ArgumentsBuilderBase<CommentNotSpamPayload, CommentNotSpamArgumentsBuilder>
    {
        protected override CommentNotSpamArgumentsBuilder Self => this;

        public CommentNotSpamArgumentsBuilder(IQuery<CommentNotSpamPayload> query) : base(query)
        {
        }

        public CommentNotSpamArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}