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
    public sealed class QueryRootMarketLocalizableResourcesArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResourceConnection?, QueryRootMarketLocalizableResourcesArgumentsBuilder>
    {
        protected override QueryRootMarketLocalizableResourcesArgumentsBuilder Self => this;

        public QueryRootMarketLocalizableResourcesArgumentsBuilder(IQuery<MarketLocalizableResourceConnection?> query) : base(query)
        {
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder ResourceType(MarketLocalizableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public QueryRootMarketLocalizableResourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}