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
    public sealed class CompanyLocationAssignAddressArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationAssignAddressPayload, CompanyLocationAssignAddressArgumentsBuilder>
    {
        protected override CompanyLocationAssignAddressArgumentsBuilder Self => this;

        public CompanyLocationAssignAddressArgumentsBuilder(IQuery<CompanyLocationAssignAddressPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignAddressArgumentsBuilder Address(CompanyAddressInput? address)
        {
            base.InnerQuery.AddArgument("address", address);
            return this;
        }

        public CompanyLocationAssignAddressArgumentsBuilder AddressTypes(ICollection<CompanyAddressType>? addressTypes)
        {
            base.InnerQuery.AddArgument("addressTypes", addressTypes);
            return this;
        }

        public CompanyLocationAssignAddressArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}