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
    public sealed class MarketingActivityUpdateExternalArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityUpdateExternalPayload, MarketingActivityUpdateExternalArgumentsBuilder>
    {
        protected override MarketingActivityUpdateExternalArgumentsBuilder Self => this;

        public MarketingActivityUpdateExternalArgumentsBuilder(IQuery<MarketingActivityUpdateExternalPayload> query) : base(query)
        {
        }

        public MarketingActivityUpdateExternalArgumentsBuilder Input(MarketingActivityUpdateExternalInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public MarketingActivityUpdateExternalArgumentsBuilder MarketingActivityId(string? marketingActivityId)
        {
            base.InnerQuery.AddArgument("marketingActivityId", marketingActivityId);
            return this;
        }

        public MarketingActivityUpdateExternalArgumentsBuilder RemoteId(string? remoteId)
        {
            base.InnerQuery.AddArgument("remoteId", remoteId);
            return this;
        }

        public MarketingActivityUpdateExternalArgumentsBuilder Utm(UTMInput? utm)
        {
            base.InnerQuery.AddArgument("utm", utm);
            return this;
        }
    }
}