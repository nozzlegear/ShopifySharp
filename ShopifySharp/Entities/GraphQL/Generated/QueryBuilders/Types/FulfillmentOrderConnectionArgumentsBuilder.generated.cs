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
    public sealed class FulfillmentOrderConnectionArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderConnection, FulfillmentOrderConnectionArgumentsBuilder>
    {
        protected override FulfillmentOrderConnectionArgumentsBuilder Self => this;

        public FulfillmentOrderConnectionArgumentsBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
        }

        public FulfillmentOrderConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder Displayable(bool? displayable)
        {
            base.InnerQuery.AddArgument("displayable", displayable);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder AssignmentStatus(FulfillmentOrderAssignmentStatus? assignmentStatus)
        {
            base.InnerQuery.AddArgument("assignmentStatus", assignmentStatus);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder SortKey(FulfillmentOrderSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public FulfillmentOrderConnectionArgumentsBuilder IncludeClosed(bool? includeClosed)
        {
            base.InnerQuery.AddArgument("includeClosed", includeClosed);
            return this;
        }
    }
}