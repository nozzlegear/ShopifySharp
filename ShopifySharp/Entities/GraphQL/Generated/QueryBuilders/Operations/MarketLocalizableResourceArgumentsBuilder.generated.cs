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
    public sealed class MarketLocalizableResourceArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResource, MarketLocalizableResourceArgumentsBuilder>
    {
        protected override MarketLocalizableResourceArgumentsBuilder Self => this;

        public MarketLocalizableResourceArgumentsBuilder(IQuery<MarketLocalizableResource> query) : base(query)
        {
        }

        public MarketLocalizableResourceArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}