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
    public sealed class ReturnableFulfillmentLineItemConnectionArgumentsBuilder : ArgumentsBuilderBase<ReturnableFulfillmentLineItemConnection, ReturnableFulfillmentLineItemConnectionArgumentsBuilder>
    {
        protected override ReturnableFulfillmentLineItemConnectionArgumentsBuilder Self => this;

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder(IQuery<ReturnableFulfillmentLineItemConnection> query) : base(query)
        {
        }

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}