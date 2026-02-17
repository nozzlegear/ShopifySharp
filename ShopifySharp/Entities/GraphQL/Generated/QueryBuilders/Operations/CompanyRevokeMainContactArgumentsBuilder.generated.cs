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
    public sealed class CompanyRevokeMainContactArgumentsBuilder : ArgumentsBuilderBase<CompanyRevokeMainContactPayload, CompanyRevokeMainContactArgumentsBuilder>
    {
        protected override CompanyRevokeMainContactArgumentsBuilder Self => this;

        public CompanyRevokeMainContactArgumentsBuilder(IQuery<CompanyRevokeMainContactPayload> query) : base(query)
        {
        }

        public CompanyRevokeMainContactArgumentsBuilder CompanyId(string? companyId)
        {
            base.InnerQuery.AddArgument("companyId", companyId);
            return this;
        }
    }
}