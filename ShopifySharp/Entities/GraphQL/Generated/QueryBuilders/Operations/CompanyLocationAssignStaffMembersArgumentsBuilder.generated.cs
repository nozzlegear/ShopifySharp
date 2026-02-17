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
    public sealed class CompanyLocationAssignStaffMembersArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationAssignStaffMembersPayload, CompanyLocationAssignStaffMembersArgumentsBuilder>
    {
        protected override CompanyLocationAssignStaffMembersArgumentsBuilder Self => this;

        public CompanyLocationAssignStaffMembersArgumentsBuilder(IQuery<CompanyLocationAssignStaffMembersPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignStaffMembersArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationAssignStaffMembersArgumentsBuilder StaffMemberIds(ICollection<string>? staffMemberIds)
        {
            base.InnerQuery.AddArgument("staffMemberIds", staffMemberIds);
            return this;
        }
    }
}