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
    public sealed class CompanyContactDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyContactDeletePayload, CompanyContactDeleteArgumentsBuilder>
    {
        protected override CompanyContactDeleteArgumentsBuilder Self => this;

        public CompanyContactDeleteArgumentsBuilder(IQuery<CompanyContactDeletePayload> query) : base(query)
        {
        }

        public CompanyContactDeleteArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }
    }
}