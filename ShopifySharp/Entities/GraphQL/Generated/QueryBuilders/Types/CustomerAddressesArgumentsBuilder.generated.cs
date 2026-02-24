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
    public sealed class CustomerAddressesArgumentsBuilder : ArgumentsBuilderBase<MailingAddress?, CustomerAddressesArgumentsBuilder>
    {
        protected override CustomerAddressesArgumentsBuilder Self => this;

        public CustomerAddressesArgumentsBuilder(IQuery<MailingAddress?> query) : base(query)
        {
        }

        public CustomerAddressesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}