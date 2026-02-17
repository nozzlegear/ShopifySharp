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
    public sealed class CompanyContactAssignRolesArgumentsBuilder : ArgumentsBuilderBase<CompanyContactAssignRolesPayload, CompanyContactAssignRolesArgumentsBuilder>
    {
        protected override CompanyContactAssignRolesArgumentsBuilder Self => this;

        public CompanyContactAssignRolesArgumentsBuilder(IQuery<CompanyContactAssignRolesPayload> query) : base(query)
        {
        }

        public CompanyContactAssignRolesArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactAssignRolesArgumentsBuilder RolesToAssign(ICollection<CompanyContactRoleAssign>? rolesToAssign)
        {
            base.InnerQuery.AddArgument("rolesToAssign", rolesToAssign);
            return this;
        }
    }
}