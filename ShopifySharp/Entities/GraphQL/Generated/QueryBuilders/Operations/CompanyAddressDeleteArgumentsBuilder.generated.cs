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
    public sealed class CompanyAddressDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyAddressDeletePayload, CompanyAddressDeleteArgumentsBuilder>
    {
        protected override CompanyAddressDeleteArgumentsBuilder Self => this;

        public CompanyAddressDeleteArgumentsBuilder(IQuery<CompanyAddressDeletePayload> query) : base(query)
        {
        }

        public CompanyAddressDeleteArgumentsBuilder AddressId(string? addressId)
        {
            base.InnerQuery.AddArgument("addressId", addressId);
            return this;
        }
    }
}