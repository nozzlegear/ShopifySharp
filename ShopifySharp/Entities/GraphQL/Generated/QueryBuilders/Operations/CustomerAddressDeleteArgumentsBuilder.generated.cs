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
    public sealed class CustomerAddressDeleteArgumentsBuilder : ArgumentsBuilderBase<CustomerAddressDeletePayload, CustomerAddressDeleteArgumentsBuilder>
    {
        protected override CustomerAddressDeleteArgumentsBuilder Self => this;

        public CustomerAddressDeleteArgumentsBuilder(IQuery<CustomerAddressDeletePayload> query) : base(query)
        {
        }

        public CustomerAddressDeleteArgumentsBuilder AddressId(string? addressId)
        {
            base.InnerQuery.AddArgument("addressId", addressId);
            return this;
        }

        public CustomerAddressDeleteArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}