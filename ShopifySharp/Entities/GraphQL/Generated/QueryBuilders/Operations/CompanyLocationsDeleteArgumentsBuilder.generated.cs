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
    public sealed class CompanyLocationsDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationsDeletePayload, CompanyLocationsDeleteArgumentsBuilder>
    {
        protected override CompanyLocationsDeleteArgumentsBuilder Self => this;

        public CompanyLocationsDeleteArgumentsBuilder(IQuery<CompanyLocationsDeletePayload> query) : base(query)
        {
        }

        public CompanyLocationsDeleteArgumentsBuilder CompanyLocationIds(ICollection<string>? companyLocationIds)
        {
            base.InnerQuery.AddArgument("companyLocationIds", companyLocationIds);
            return this;
        }
    }
}