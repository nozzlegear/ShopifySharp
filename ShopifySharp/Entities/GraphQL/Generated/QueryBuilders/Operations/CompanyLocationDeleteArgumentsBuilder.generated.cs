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
    public sealed class CompanyLocationDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationDeletePayload, CompanyLocationDeleteArgumentsBuilder>
    {
        protected override CompanyLocationDeleteArgumentsBuilder Self => this;

        public CompanyLocationDeleteArgumentsBuilder(IQuery<CompanyLocationDeletePayload> query) : base(query)
        {
        }

        public CompanyLocationDeleteArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }
    }
}