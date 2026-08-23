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
    public sealed class CommentEventEmbedPaymentMethodsArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodConnection?, CommentEventEmbedPaymentMethodsArgumentsBuilder>
    {
        protected override CommentEventEmbedPaymentMethodsArgumentsBuilder Self => this;

        public CommentEventEmbedPaymentMethodsArgumentsBuilder(IQuery<CustomerPaymentMethodConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CommentEventEmbedPaymentMethodsArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}