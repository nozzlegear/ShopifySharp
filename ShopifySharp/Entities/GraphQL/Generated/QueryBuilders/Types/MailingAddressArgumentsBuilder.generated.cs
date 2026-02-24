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
    public sealed class MailingAddressArgumentsBuilder : ArgumentsBuilderBase<MailingAddress, MailingAddressArgumentsBuilder>
    {
        protected override MailingAddressArgumentsBuilder Self => this;

        public MailingAddressArgumentsBuilder(IQuery<MailingAddress> query) : base(query)
        {
        }

        public MailingAddressArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}