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
    public sealed class MarketingActivityConnectionArgumentsBuilder : ArgumentsBuilderBase<MarketingActivityConnection, MarketingActivityConnectionArgumentsBuilder>
    {
        protected override MarketingActivityConnectionArgumentsBuilder Self => this;

        public MarketingActivityConnectionArgumentsBuilder(IQuery<MarketingActivityConnection> query) : base(query)
        {
        }

        public MarketingActivityConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder MarketingActivityIds(ICollection<string>? marketingActivityIds)
        {
            base.InnerQuery.AddArgument("marketingActivityIds", marketingActivityIds);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder RemoteIds(ICollection<string>? remoteIds)
        {
            base.InnerQuery.AddArgument("remoteIds", remoteIds);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder SortKey(MarketingActivitySortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public MarketingActivityConnectionArgumentsBuilder Utm(UTMInput? utm)
        {
            base.InnerQuery.AddArgument("utm", utm);
            return this;
        }
    }
}