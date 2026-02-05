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