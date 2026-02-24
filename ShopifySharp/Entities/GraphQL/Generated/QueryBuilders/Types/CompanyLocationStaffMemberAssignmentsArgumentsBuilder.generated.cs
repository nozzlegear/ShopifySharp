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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CompanyLocationStaffMemberAssignmentsArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationStaffMemberAssignmentConnection?, CompanyLocationStaffMemberAssignmentsArgumentsBuilder>
    {
        protected override CompanyLocationStaffMemberAssignmentsArgumentsBuilder Self => this;

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder(IQuery<CompanyLocationStaffMemberAssignmentConnection?> query) : base(query)
        {
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentsArgumentsBuilder SortKey(CompanyLocationStaffMemberAssignmentSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}