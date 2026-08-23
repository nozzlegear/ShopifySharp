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
    public sealed class CommentEventEmbedFulfillmentOrdersArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderConnection?, CommentEventEmbedFulfillmentOrdersArgumentsBuilder>
    {
        protected override CommentEventEmbedFulfillmentOrdersArgumentsBuilder Self => this;

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder(IQuery<FulfillmentOrderConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Displayable(bool? displayable)
        {
            base.InnerQuery.AddArgument("displayable", displayable);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CommentEventEmbedFulfillmentOrdersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}