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
    public sealed class CommentEventEmbedFulfillmentsArgumentsBuilder : ArgumentsBuilderBase<Fulfillment?, CommentEventEmbedFulfillmentsArgumentsBuilder>
    {
        protected override CommentEventEmbedFulfillmentsArgumentsBuilder Self => this;

        public CommentEventEmbedFulfillmentsArgumentsBuilder(IQuery<Fulfillment?> query) : base(query)
        {
        }

        public CommentEventEmbedFulfillmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedFulfillmentsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}