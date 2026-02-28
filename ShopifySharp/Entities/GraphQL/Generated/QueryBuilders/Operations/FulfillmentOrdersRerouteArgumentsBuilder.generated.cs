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
    public sealed class FulfillmentOrdersRerouteArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrdersReroutePayload, FulfillmentOrdersRerouteArgumentsBuilder>
    {
        protected override FulfillmentOrdersRerouteArgumentsBuilder Self => this;

        public FulfillmentOrdersRerouteArgumentsBuilder(IQuery<FulfillmentOrdersReroutePayload> query) : base(query)
        {
        }

        public FulfillmentOrdersRerouteArgumentsBuilder ExcludedLocationIds(ICollection<string>? excludedLocationIds)
        {
            base.InnerQuery.AddArgument("excludedLocationIds", excludedLocationIds);
            return this;
        }

        public FulfillmentOrdersRerouteArgumentsBuilder FulfillmentOrderIds(ICollection<string>? fulfillmentOrderIds)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderIds", fulfillmentOrderIds);
            return this;
        }

        public FulfillmentOrdersRerouteArgumentsBuilder IncludedLocationIds(ICollection<string>? includedLocationIds)
        {
            base.InnerQuery.AddArgument("includedLocationIds", includedLocationIds);
            return this;
        }
    }
}