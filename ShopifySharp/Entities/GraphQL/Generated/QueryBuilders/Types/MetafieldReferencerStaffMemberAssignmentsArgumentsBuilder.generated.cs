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
    public sealed class MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationStaffMemberAssignmentConnection?, MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder>
    {
        protected override MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Self => this;

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder(IQuery<CompanyLocationStaffMemberAssignmentConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder SortKey(CompanyLocationStaffMemberAssignmentSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}