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
    public sealed class MarketingActivityUpsertExternalArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityUpsertExternalPayload, MarketingActivityUpsertExternalArgumentsBuilder>
    {
        protected override MarketingActivityUpsertExternalArgumentsBuilder Self => this;

        public MarketingActivityUpsertExternalArgumentsBuilder(IQuery<MarketingActivityUpsertExternalPayload> query) : base(query)
        {
        }

        public MarketingActivityUpsertExternalArgumentsBuilder Input(MarketingActivityUpsertExternalInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}