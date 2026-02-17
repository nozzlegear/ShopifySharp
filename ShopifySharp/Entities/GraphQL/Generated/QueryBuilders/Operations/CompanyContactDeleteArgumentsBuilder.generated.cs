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