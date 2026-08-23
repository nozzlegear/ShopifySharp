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
    public sealed class CommentEventEmbedAddressesArgumentsBuilder : ArgumentsBuilderBase<MailingAddress?, CommentEventEmbedAddressesArgumentsBuilder>
    {
        protected override CommentEventEmbedAddressesArgumentsBuilder Self => this;

        public CommentEventEmbedAddressesArgumentsBuilder(IQuery<MailingAddress?> query) : base(query)
        {
        }

        public CommentEventEmbedAddressesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}