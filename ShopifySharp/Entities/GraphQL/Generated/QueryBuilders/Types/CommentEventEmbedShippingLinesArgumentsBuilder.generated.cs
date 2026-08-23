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
    public sealed class CommentEventEmbedShippingLinesArgumentsBuilder : ArgumentsBuilderBase<ShippingLineConnection?, CommentEventEmbedShippingLinesArgumentsBuilder>
    {
        protected override CommentEventEmbedShippingLinesArgumentsBuilder Self => this;

        public CommentEventEmbedShippingLinesArgumentsBuilder(IQuery<ShippingLineConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder IncludeRemovals(bool? includeRemovals)
        {
            base.InnerQuery.AddArgument("includeRemovals", includeRemovals);
            return this;
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedShippingLinesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}