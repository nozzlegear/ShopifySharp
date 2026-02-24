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
    public sealed class LocationConnectionArgumentsBuilder : ArgumentsBuilderBase<LocationConnection, LocationConnectionArgumentsBuilder>
    {
        protected override LocationConnectionArgumentsBuilder Self => this;

        public LocationConnectionArgumentsBuilder(IQuery<LocationConnection> query) : base(query)
        {
        }

        public LocationConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public LocationConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public LocationConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public LocationConnectionArgumentsBuilder IncludeInactive(bool? includeInactive)
        {
            base.InnerQuery.AddArgument("includeInactive", includeInactive);
            return this;
        }

        public LocationConnectionArgumentsBuilder IncludeLegacy(bool? includeLegacy)
        {
            base.InnerQuery.AddArgument("includeLegacy", includeLegacy);
            return this;
        }

        public LocationConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public LocationConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public LocationConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public LocationConnectionArgumentsBuilder SortKey(LocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}