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
    public sealed class ReturnExchangeLineItemsArgumentsBuilder : ArgumentsBuilderBase<ExchangeLineItemConnection?, ReturnExchangeLineItemsArgumentsBuilder>
    {
        protected override ReturnExchangeLineItemsArgumentsBuilder Self => this;

        public ReturnExchangeLineItemsArgumentsBuilder(IQuery<ExchangeLineItemConnection?> query) : base(query)
        {
        }

        public ReturnExchangeLineItemsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnExchangeLineItemsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnExchangeLineItemsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnExchangeLineItemsArgumentsBuilder IncludeRemovedItems(bool? includeRemovedItems)
        {
            base.InnerQuery.AddArgument("includeRemovedItems", includeRemovedItems);
            return this;
        }

        public ReturnExchangeLineItemsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnExchangeLineItemsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}