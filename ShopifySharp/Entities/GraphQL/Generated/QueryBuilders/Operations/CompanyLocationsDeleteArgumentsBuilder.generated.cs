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