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