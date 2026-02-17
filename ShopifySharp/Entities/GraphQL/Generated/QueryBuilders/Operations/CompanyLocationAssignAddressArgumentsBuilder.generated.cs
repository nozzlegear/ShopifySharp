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