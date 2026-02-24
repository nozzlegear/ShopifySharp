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
    public sealed class QueryRootMarketingActivityArgumentsBuilder : ArgumentsBuilderBase<MarketingActivity?, QueryRootMarketingActivityArgumentsBuilder>
    {
        protected override QueryRootMarketingActivityArgumentsBuilder Self => this;

        public QueryRootMarketingActivityArgumentsBuilder(IQuery<MarketingActivity?> query) : base(query)
        {
        }

        public QueryRootMarketingActivityArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}