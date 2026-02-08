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
    public sealed class LocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection, LocationsArgumentsBuilder>
    {
        protected override LocationsArgumentsBuilder Self => this;

        public LocationsArgumentsBuilder(IQuery<LocationConnection> query) : base(query)
        {
        }

        public LocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public LocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public LocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public LocationsArgumentsBuilder IncludeInactive(bool? includeInactive)
        {
            base.InnerQuery.AddArgument("includeInactive", includeInactive);
            return this;
        }

        public LocationsArgumentsBuilder IncludeLegacy(bool? includeLegacy)
        {
            base.InnerQuery.AddArgument("includeLegacy", includeLegacy);
            return this;
        }

        public LocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public LocationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public LocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public LocationsArgumentsBuilder SortKey(LocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}