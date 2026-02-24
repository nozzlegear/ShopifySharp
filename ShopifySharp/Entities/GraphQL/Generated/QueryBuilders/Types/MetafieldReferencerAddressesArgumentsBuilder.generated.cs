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
    public sealed class MetafieldReferencerAddressesArgumentsBuilder : ArgumentsBuilderBase<MailingAddress?, MetafieldReferencerAddressesArgumentsBuilder>
    {
        protected override MetafieldReferencerAddressesArgumentsBuilder Self => this;

        public MetafieldReferencerAddressesArgumentsBuilder(IQuery<MailingAddress?> query) : base(query)
        {
        }

        public MetafieldReferencerAddressesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}