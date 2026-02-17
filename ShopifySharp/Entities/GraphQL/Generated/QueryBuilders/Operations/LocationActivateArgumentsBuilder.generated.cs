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
    public sealed class LocationActivateArgumentsBuilder : ArgumentsBuilderBase<LocationActivatePayload, LocationActivateArgumentsBuilder>
    {
        protected override LocationActivateArgumentsBuilder Self => this;

        public LocationActivateArgumentsBuilder(IQuery<LocationActivatePayload> query) : base(query)
        {
        }

        public LocationActivateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }
    }
}