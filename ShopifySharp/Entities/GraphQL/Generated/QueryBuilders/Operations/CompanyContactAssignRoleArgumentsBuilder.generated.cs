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
    public sealed class CompanyContactAssignRoleArgumentsBuilder : ArgumentsBuilderBase<CompanyContactAssignRolePayload, CompanyContactAssignRoleArgumentsBuilder>
    {
        protected override CompanyContactAssignRoleArgumentsBuilder Self => this;

        public CompanyContactAssignRoleArgumentsBuilder(IQuery<CompanyContactAssignRolePayload> query) : base(query)
        {
        }

        public CompanyContactAssignRoleArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactAssignRoleArgumentsBuilder CompanyContactRoleId(string? companyContactRoleId)
        {
            base.InnerQuery.AddArgument("companyContactRoleId", companyContactRoleId);
            return this;
        }

        public CompanyContactAssignRoleArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }
    }
}