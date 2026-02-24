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
    public sealed class QueryRootMarketingEventArgumentsBuilder : ArgumentsBuilderBase<MarketingEvent?, QueryRootMarketingEventArgumentsBuilder>
    {
        protected override QueryRootMarketingEventArgumentsBuilder Self => this;

        public QueryRootMarketingEventArgumentsBuilder(IQuery<MarketingEvent?> query) : base(query)
        {
        }

        public QueryRootMarketingEventArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}