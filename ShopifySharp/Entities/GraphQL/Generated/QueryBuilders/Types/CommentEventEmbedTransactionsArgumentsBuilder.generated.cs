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
    public sealed class CommentEventEmbedTransactionsArgumentsBuilder : ArgumentsBuilderBase<OrderTransaction?, CommentEventEmbedTransactionsArgumentsBuilder>
    {
        protected override CommentEventEmbedTransactionsArgumentsBuilder Self => this;

        public CommentEventEmbedTransactionsArgumentsBuilder(IQuery<OrderTransaction?> query) : base(query)
        {
        }

        public CommentEventEmbedTransactionsArgumentsBuilder Capturable(bool? capturable)
        {
            base.InnerQuery.AddArgument("capturable", capturable);
            return this;
        }

        public CommentEventEmbedTransactionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedTransactionsArgumentsBuilder ManuallyResolvable(bool? manuallyResolvable)
        {
            base.InnerQuery.AddArgument("manuallyResolvable", manuallyResolvable);
            return this;
        }
    }
}