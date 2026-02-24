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
    public sealed class QueryRootStaffMemberArgumentsBuilder : ArgumentsBuilderBase<StaffMember?, QueryRootStaffMemberArgumentsBuilder>
    {
        protected override QueryRootStaffMemberArgumentsBuilder Self => this;

        public QueryRootStaffMemberArgumentsBuilder(IQuery<StaffMember?> query) : base(query)
        {
        }

        public QueryRootStaffMemberArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}