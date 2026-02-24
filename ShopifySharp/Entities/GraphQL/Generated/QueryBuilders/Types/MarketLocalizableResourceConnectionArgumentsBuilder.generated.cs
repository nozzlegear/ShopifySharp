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
    public sealed class MarketLocalizableResourceConnectionArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourceConnectionArgumentsBuilder>
    {
        protected override MarketLocalizableResourceConnectionArgumentsBuilder Self => this;

        public MarketLocalizableResourceConnectionArgumentsBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder ResourceType(MarketLocalizableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MarketLocalizableResourceConnectionArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }
    }
}