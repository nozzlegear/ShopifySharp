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