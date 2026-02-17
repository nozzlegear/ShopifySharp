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
    public sealed class FulfillmentOrderReleaseHoldArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderReleaseHoldPayload, FulfillmentOrderReleaseHoldArgumentsBuilder>
    {
        protected override FulfillmentOrderReleaseHoldArgumentsBuilder Self => this;

        public FulfillmentOrderReleaseHoldArgumentsBuilder(IQuery<FulfillmentOrderReleaseHoldPayload> query) : base(query)
        {
        }

        public FulfillmentOrderReleaseHoldArgumentsBuilder ExternalId(string? externalId)
        {
            base.InnerQuery.AddArgument("externalId", externalId);
            return this;
        }

        public FulfillmentOrderReleaseHoldArgumentsBuilder HoldIds(ICollection<string>? holdIds)
        {
            base.InnerQuery.AddArgument("holdIds", holdIds);
            return this;
        }

        public FulfillmentOrderReleaseHoldArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}