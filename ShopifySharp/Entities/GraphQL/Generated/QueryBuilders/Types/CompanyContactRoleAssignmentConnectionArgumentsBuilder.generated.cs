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
    public sealed class CompanyContactRoleAssignmentConnectionArgumentsBuilder : ArgumentsBuilderBase<CompanyContactRoleAssignmentConnection, CompanyContactRoleAssignmentConnectionArgumentsBuilder>
    {
        protected override CompanyContactRoleAssignmentConnectionArgumentsBuilder Self => this;

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder(IQuery<CompanyContactRoleAssignmentConnection> query) : base(query)
        {
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionArgumentsBuilder SortKey(CompanyContactRoleAssignmentSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}