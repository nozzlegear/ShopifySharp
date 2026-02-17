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
    public sealed class CustomerUpdateDefaultAddressArgumentsBuilder : ArgumentsBuilderBase<CustomerUpdateDefaultAddressPayload, CustomerUpdateDefaultAddressArgumentsBuilder>
    {
        protected override CustomerUpdateDefaultAddressArgumentsBuilder Self => this;

        public CustomerUpdateDefaultAddressArgumentsBuilder(IQuery<CustomerUpdateDefaultAddressPayload> query) : base(query)
        {
        }

        public CustomerUpdateDefaultAddressArgumentsBuilder AddressId(string? addressId)
        {
            base.InnerQuery.AddArgument("addressId", addressId);
            return this;
        }

        public CustomerUpdateDefaultAddressArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}