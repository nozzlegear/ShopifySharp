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
    public sealed class CompanyAssignMainContactArgumentsBuilder : ArgumentsBuilderBase<CompanyAssignMainContactPayload, CompanyAssignMainContactArgumentsBuilder>
    {
        protected override CompanyAssignMainContactArgumentsBuilder Self => this;

        public CompanyAssignMainContactArgumentsBuilder(IQuery<CompanyAssignMainContactPayload> query) : base(query)
        {
        }

        public CompanyAssignMainContactArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyAssignMainContactArgumentsBuilder CompanyId(string? companyId)
        {
            base.InnerQuery.AddArgument("companyId", companyId);
            return this;
        }
    }
}