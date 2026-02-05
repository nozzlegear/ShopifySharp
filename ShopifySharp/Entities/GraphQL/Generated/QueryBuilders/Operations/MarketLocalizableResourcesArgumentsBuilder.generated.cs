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
    public sealed class MarketLocalizableResourcesArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourcesArgumentsBuilder>
    {
        protected override MarketLocalizableResourcesArgumentsBuilder Self => this;

        public MarketLocalizableResourcesArgumentsBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
        }

        public MarketLocalizableResourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketLocalizableResourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketLocalizableResourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketLocalizableResourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketLocalizableResourcesArgumentsBuilder ResourceType(MarketLocalizableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public MarketLocalizableResourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}