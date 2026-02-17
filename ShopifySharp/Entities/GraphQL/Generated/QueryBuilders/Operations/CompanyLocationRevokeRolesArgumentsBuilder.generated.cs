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