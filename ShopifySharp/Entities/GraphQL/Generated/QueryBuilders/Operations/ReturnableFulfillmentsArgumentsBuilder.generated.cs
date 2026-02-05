#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ReturnableFulfillmentsArgumentsBuilder : ArgumentsBuilderBase<ReturnableFulfillmentConnection, ReturnableFulfillmentsArgumentsBuilder>
    {
        protected override ReturnableFulfillmentsArgumentsBuilder Self => this;

        public ReturnableFulfillmentsArgumentsBuilder(IQuery<ReturnableFulfillmentConnection> query) : base(query)
        {
        }

        public ReturnableFulfillmentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnableFulfillmentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnableFulfillmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnableFulfillmentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnableFulfillmentsArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }

        public ReturnableFulfillmentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}