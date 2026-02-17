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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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