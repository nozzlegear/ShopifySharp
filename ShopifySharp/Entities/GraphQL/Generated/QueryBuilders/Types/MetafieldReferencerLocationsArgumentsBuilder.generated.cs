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
    public sealed class MetafieldReferencerLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, MetafieldReferencerLocationsArgumentsBuilder>
    {
        protected override MetafieldReferencerLocationsArgumentsBuilder Self => this;

        public MetafieldReferencerLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder IncludeInactive(bool? includeInactive)
        {
            base.InnerQuery.AddArgument("includeInactive", includeInactive);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder IncludeLegacy(bool? includeLegacy)
        {
            base.InnerQuery.AddArgument("includeLegacy", includeLegacy);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MetafieldReferencerLocationsArgumentsBuilder SortKey(LocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}