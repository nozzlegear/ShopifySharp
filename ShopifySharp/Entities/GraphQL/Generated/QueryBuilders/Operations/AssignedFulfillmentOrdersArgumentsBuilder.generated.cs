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
    public sealed class AssignedFulfillmentOrdersArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderConnection, AssignedFulfillmentOrdersArgumentsBuilder>
    {
        protected override AssignedFulfillmentOrdersArgumentsBuilder Self => this;

        public AssignedFulfillmentOrdersArgumentsBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
        }

        public AssignedFulfillmentOrdersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder AssignmentStatus(FulfillmentOrderAssignmentStatus? assignmentStatus)
        {
            base.InnerQuery.AddArgument("assignmentStatus", assignmentStatus);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AssignedFulfillmentOrdersArgumentsBuilder SortKey(FulfillmentOrderSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}