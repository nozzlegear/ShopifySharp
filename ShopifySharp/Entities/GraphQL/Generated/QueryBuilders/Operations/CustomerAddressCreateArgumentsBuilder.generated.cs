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
    public sealed class CustomerAddressCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerAddressCreatePayload, CustomerAddressCreateArgumentsBuilder>
    {
        protected override CustomerAddressCreateArgumentsBuilder Self => this;

        public CustomerAddressCreateArgumentsBuilder(IQuery<CustomerAddressCreatePayload> query) : base(query)
        {
        }

        public CustomerAddressCreateArgumentsBuilder Address(MailingAddressInput? address)
        {
            base.InnerQuery.AddArgument("address", address);
            return this;
        }

        public CustomerAddressCreateArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerAddressCreateArgumentsBuilder SetAsDefault(bool? setAsDefault)
        {
            base.InnerQuery.AddArgument("setAsDefault", setAsDefault);
            return this;
        }
    }
}