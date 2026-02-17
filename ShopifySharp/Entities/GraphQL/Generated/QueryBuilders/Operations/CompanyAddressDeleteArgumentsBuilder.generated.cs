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