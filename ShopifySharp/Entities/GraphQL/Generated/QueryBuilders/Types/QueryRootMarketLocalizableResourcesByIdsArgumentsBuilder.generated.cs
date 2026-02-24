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
    public sealed class QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizableResourceConnection?, QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder>
    {
        protected override QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder Self => this;

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder(IQuery<MarketLocalizableResourceConnection?> query) : base(query)
        {
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }

        public QueryRootMarketLocalizableResourcesByIdsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}