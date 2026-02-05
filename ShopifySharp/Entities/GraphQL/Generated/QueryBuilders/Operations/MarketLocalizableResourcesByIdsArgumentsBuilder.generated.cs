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
    public sealed class MarketLocalizableResourcesByIdsArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourcesByIdsArgumentsBuilder>
    {
        protected override MarketLocalizableResourcesByIdsArgumentsBuilder Self => this;

        public MarketLocalizableResourcesByIdsArgumentsBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }

        public MarketLocalizableResourcesByIdsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}