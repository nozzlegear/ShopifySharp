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
    public sealed class ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder : ArgumentsBuilderBase<ReturnableFulfillmentLineItemConnection?, ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder>
    {
        protected override ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder Self => this;

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder(IQuery<ReturnableFulfillmentLineItemConnection?> query) : base(query)
        {
        }

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnableFulfillmentReturnableFulfillmentLineItemsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}