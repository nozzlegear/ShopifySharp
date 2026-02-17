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
    public sealed class CompanyContactRevokeRoleArgumentsBuilder : ArgumentsBuilderBase<CompanyContactRevokeRolePayload, CompanyContactRevokeRoleArgumentsBuilder>
    {
        protected override CompanyContactRevokeRoleArgumentsBuilder Self => this;

        public CompanyContactRevokeRoleArgumentsBuilder(IQuery<CompanyContactRevokeRolePayload> query) : base(query)
        {
        }

        public CompanyContactRevokeRoleArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactRevokeRoleArgumentsBuilder CompanyContactRoleAssignmentId(string? companyContactRoleAssignmentId)
        {
            base.InnerQuery.AddArgument("companyContactRoleAssignmentId", companyContactRoleAssignmentId);
            return this;
        }
    }
}