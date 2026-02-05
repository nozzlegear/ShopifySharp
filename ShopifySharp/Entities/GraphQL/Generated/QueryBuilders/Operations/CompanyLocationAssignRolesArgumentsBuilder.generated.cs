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
    public sealed class CompanyLocationAssignRolesArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationAssignRolesPayload, CompanyLocationAssignRolesArgumentsBuilder>
    {
        protected override CompanyLocationAssignRolesArgumentsBuilder Self => this;

        public CompanyLocationAssignRolesArgumentsBuilder(IQuery<CompanyLocationAssignRolesPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignRolesArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationAssignRolesArgumentsBuilder RolesToAssign(ICollection<CompanyLocationRoleAssign>? rolesToAssign)
        {
            base.InnerQuery.AddArgument("rolesToAssign", rolesToAssign);
            return this;
        }
    }
}