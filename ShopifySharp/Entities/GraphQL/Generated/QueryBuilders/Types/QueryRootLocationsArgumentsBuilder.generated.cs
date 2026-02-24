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
    public sealed class QueryRootLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, QueryRootLocationsArgumentsBuilder>
    {
        protected override QueryRootLocationsArgumentsBuilder Self => this;

        public QueryRootLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public QueryRootLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder IncludeInactive(bool? includeInactive)
        {
            base.InnerQuery.AddArgument("includeInactive", includeInactive);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder IncludeLegacy(bool? includeLegacy)
        {
            base.InnerQuery.AddArgument("includeLegacy", includeLegacy);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootLocationsArgumentsBuilder SortKey(LocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}