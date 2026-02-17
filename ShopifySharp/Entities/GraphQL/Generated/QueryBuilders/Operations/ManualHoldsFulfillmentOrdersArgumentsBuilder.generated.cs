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
    public sealed class ManualHoldsFulfillmentOrdersArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderConnection, ManualHoldsFulfillmentOrdersArgumentsBuilder>
    {
        protected override ManualHoldsFulfillmentOrdersArgumentsBuilder Self => this;

        public ManualHoldsFulfillmentOrdersArgumentsBuilder(IQuery<FulfillmentOrderConnection> query) : base(query)
        {
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ManualHoldsFulfillmentOrdersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}