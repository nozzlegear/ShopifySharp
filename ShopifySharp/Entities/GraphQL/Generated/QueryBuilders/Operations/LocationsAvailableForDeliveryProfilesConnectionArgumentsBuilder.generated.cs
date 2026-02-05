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
    public sealed class LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder : ArgumentsBuilderBase<LocationConnection, LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder>
    {
        protected override LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder Self => this;

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder(IQuery<LocationConnection> query) : base(query)
        {
        }

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}