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
    public sealed class MarketingActivitiesArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityConnection, MarketingActivitiesArgumentsBuilder>
    {
        protected override MarketingActivitiesArgumentsBuilder Self => this;

        public MarketingActivitiesArgumentsBuilder(IQuery<MarketingActivityConnection> query) : base(query)
        {
        }

        public MarketingActivitiesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder MarketingActivityIds(ICollection<string>? marketingActivityIds)
        {
            base.InnerQuery.AddArgument("marketingActivityIds", marketingActivityIds);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder RemoteIds(ICollection<string>? remoteIds)
        {
            base.InnerQuery.AddArgument("remoteIds", remoteIds);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder SortKey(MarketingActivitySortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public MarketingActivitiesArgumentsBuilder Utm(UTMInput? utm)
        {
            base.InnerQuery.AddArgument("utm", utm);
            return this;
        }
    }
}