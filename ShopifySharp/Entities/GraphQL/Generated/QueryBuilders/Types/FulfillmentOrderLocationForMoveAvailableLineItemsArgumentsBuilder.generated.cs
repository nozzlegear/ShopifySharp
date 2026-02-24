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
    public sealed class FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderLineItemConnection?, FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder>
    {
        protected override FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder Self => this;

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder(IQuery<FulfillmentOrderLineItemConnection?> query) : base(query)
        {
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}