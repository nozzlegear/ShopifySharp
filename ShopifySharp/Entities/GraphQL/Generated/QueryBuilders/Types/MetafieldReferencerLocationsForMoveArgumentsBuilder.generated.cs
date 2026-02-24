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
    public sealed class MetafieldReferencerLocationsForMoveArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderLocationForMoveConnection?, MetafieldReferencerLocationsForMoveArgumentsBuilder>
    {
        protected override MetafieldReferencerLocationsForMoveArgumentsBuilder Self => this;

        public MetafieldReferencerLocationsForMoveArgumentsBuilder(IQuery<FulfillmentOrderLocationForMoveConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder LineItemIds(ICollection<string>? lineItemIds)
        {
            base.InnerQuery.AddArgument("lineItemIds", lineItemIds);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldReferencerLocationsForMoveArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}