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
    public sealed class CompanyLocationRevokeRolesArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationRevokeRolesPayload, CompanyLocationRevokeRolesArgumentsBuilder>
    {
        protected override CompanyLocationRevokeRolesArgumentsBuilder Self => this;

        public CompanyLocationRevokeRolesArgumentsBuilder(IQuery<CompanyLocationRevokeRolesPayload> query) : base(query)
        {
        }

        public CompanyLocationRevokeRolesArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationRevokeRolesArgumentsBuilder RolesToRevoke(ICollection<string>? rolesToRevoke)
        {
            base.InnerQuery.AddArgument("rolesToRevoke", rolesToRevoke);
            return this;
        }
    }
}