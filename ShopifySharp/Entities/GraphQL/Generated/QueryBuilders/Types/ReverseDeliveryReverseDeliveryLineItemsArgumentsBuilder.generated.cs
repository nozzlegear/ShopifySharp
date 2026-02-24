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
    public sealed class ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder : ArgumentsBuilderBase<ReverseDeliveryLineItemConnection?, ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder>
    {
        protected override ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder Self => this;

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder(IQuery<ReverseDeliveryLineItemConnection?> query) : base(query)
        {
        }

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReverseDeliveryReverseDeliveryLineItemsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}