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
    public sealed class CustomerAddressUpdateArgumentsBuilder : ArgumentsBuilderBase<CustomerAddressUpdatePayload, CustomerAddressUpdateArgumentsBuilder>
    {
        protected override CustomerAddressUpdateArgumentsBuilder Self => this;

        public CustomerAddressUpdateArgumentsBuilder(IQuery<CustomerAddressUpdatePayload> query) : base(query)
        {
        }

        public CustomerAddressUpdateArgumentsBuilder Address(MailingAddressInput? address)
        {
            base.InnerQuery.AddArgument("address", address);
            return this;
        }

        public CustomerAddressUpdateArgumentsBuilder AddressId(string? addressId)
        {
            base.InnerQuery.AddArgument("addressId", addressId);
            return this;
        }

        public CustomerAddressUpdateArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerAddressUpdateArgumentsBuilder SetAsDefault(bool? setAsDefault)
        {
            base.InnerQuery.AddArgument("setAsDefault", setAsDefault);
            return this;
        }
    }
}