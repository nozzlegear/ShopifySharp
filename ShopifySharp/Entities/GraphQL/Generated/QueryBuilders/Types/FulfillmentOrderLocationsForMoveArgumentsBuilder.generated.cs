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
    public sealed class FulfillmentOrderLocationsForMoveArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderLocationForMoveConnection?, FulfillmentOrderLocationsForMoveArgumentsBuilder>
    {
        protected override FulfillmentOrderLocationsForMoveArgumentsBuilder Self => this;

        public FulfillmentOrderLocationsForMoveArgumentsBuilder(IQuery<FulfillmentOrderLocationForMoveConnection?> query) : base(query)
        {
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder LineItemIds(ICollection<string>? lineItemIds)
        {
            base.InnerQuery.AddArgument("lineItemIds", lineItemIds);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public FulfillmentOrderLocationsForMoveArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}