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
    public sealed class CompanyLocationRoleAssignmentsArgumentsBuilder : ArgumentsBuilderBase<CompanyContactRoleAssignmentConnection?, CompanyLocationRoleAssignmentsArgumentsBuilder>
    {
        protected override CompanyLocationRoleAssignmentsArgumentsBuilder Self => this;

        public CompanyLocationRoleAssignmentsArgumentsBuilder(IQuery<CompanyContactRoleAssignmentConnection?> query) : base(query)
        {
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CompanyLocationRoleAssignmentsArgumentsBuilder SortKey(CompanyContactRoleAssignmentSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}