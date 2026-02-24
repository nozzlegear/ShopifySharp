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
    public sealed class QueryRootMarketLocalizableResourceArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResource?, QueryRootMarketLocalizableResourceArgumentsBuilder>
    {
        protected override QueryRootMarketLocalizableResourceArgumentsBuilder Self => this;

        public QueryRootMarketLocalizableResourceArgumentsBuilder(IQuery<MarketLocalizableResource?> query) : base(query)
        {
        }

        public QueryRootMarketLocalizableResourceArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}