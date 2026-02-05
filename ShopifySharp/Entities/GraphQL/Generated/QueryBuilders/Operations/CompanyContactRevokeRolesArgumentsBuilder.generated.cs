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
    public sealed class CompanyContactRevokeRolesArgumentsBuilder : ArgumentsBuilderBase<CompanyContactRevokeRolesPayload, CompanyContactRevokeRolesArgumentsBuilder>
    {
        protected override CompanyContactRevokeRolesArgumentsBuilder Self => this;

        public CompanyContactRevokeRolesArgumentsBuilder(IQuery<CompanyContactRevokeRolesPayload> query) : base(query)
        {
        }

        public CompanyContactRevokeRolesArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactRevokeRolesArgumentsBuilder RevokeAll(bool? revokeAll)
        {
            base.InnerQuery.AddArgument("revokeAll", revokeAll);
            return this;
        }

        public CompanyContactRevokeRolesArgumentsBuilder RoleAssignmentIds(ICollection<string>? roleAssignmentIds)
        {
            base.InnerQuery.AddArgument("roleAssignmentIds", roleAssignmentIds);
            return this;
        }
    }
}