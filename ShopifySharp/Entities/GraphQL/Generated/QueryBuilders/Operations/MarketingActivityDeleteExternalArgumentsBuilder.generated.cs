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
    public sealed class MarketingActivityDeleteExternalArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityDeleteExternalPayload, MarketingActivityDeleteExternalArgumentsBuilder>
    {
        protected override MarketingActivityDeleteExternalArgumentsBuilder Self => this;

        public MarketingActivityDeleteExternalArgumentsBuilder(IQuery<MarketingActivityDeleteExternalPayload> query) : base(query)
        {
        }

        public MarketingActivityDeleteExternalArgumentsBuilder MarketingActivityId(string? marketingActivityId)
        {
            base.InnerQuery.AddArgument("marketingActivityId", marketingActivityId);
            return this;
        }

        public MarketingActivityDeleteExternalArgumentsBuilder RemoteId(string? remoteId)
        {
            base.InnerQuery.AddArgument("remoteId", remoteId);
            return this;
        }
    }
}