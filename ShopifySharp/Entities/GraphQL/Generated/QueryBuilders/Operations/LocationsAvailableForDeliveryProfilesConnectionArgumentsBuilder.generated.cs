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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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