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
    public sealed class QueryRootMarketingActivitiesArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityConnection?, QueryRootMarketingActivitiesArgumentsBuilder>
    {
        protected override QueryRootMarketingActivitiesArgumentsBuilder Self => this;

        public QueryRootMarketingActivitiesArgumentsBuilder(IQuery<MarketingActivityConnection?> query) : base(query)
        {
        }

        public QueryRootMarketingActivitiesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder MarketingActivityIds(ICollection<string>? marketingActivityIds)
        {
            base.InnerQuery.AddArgument("marketingActivityIds", marketingActivityIds);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder RemoteIds(ICollection<string>? remoteIds)
        {
            base.InnerQuery.AddArgument("remoteIds", remoteIds);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder SortKey(MarketingActivitySortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public QueryRootMarketingActivitiesArgumentsBuilder Utm(UTMInput? utm)
        {
            base.InnerQuery.AddArgument("utm", utm);
            return this;
        }
    }
}