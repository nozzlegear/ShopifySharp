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
    public sealed class ShopLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, ShopLocationsArgumentsBuilder>
    {
        protected override ShopLocationsArgumentsBuilder Self => this;

        public ShopLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public ShopLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopLocationsArgumentsBuilder IncludeInactive(bool? includeInactive)
        {
            base.InnerQuery.AddArgument("includeInactive", includeInactive);
            return this;
        }

        public ShopLocationsArgumentsBuilder IncludeLegacy(bool? includeLegacy)
        {
            base.InnerQuery.AddArgument("includeLegacy", includeLegacy);
            return this;
        }

        public ShopLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopLocationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopLocationsArgumentsBuilder SortKey(LocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}