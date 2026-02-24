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
    public sealed class QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderConnection?, QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder>
    {
        protected override QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder Self => this;

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder(IQuery<FulfillmentOrderConnection?> query) : base(query)
        {
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootManualHoldsFulfillmentOrdersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}