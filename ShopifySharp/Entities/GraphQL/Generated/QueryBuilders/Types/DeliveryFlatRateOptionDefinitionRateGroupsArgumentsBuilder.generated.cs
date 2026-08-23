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
    public sealed class DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder : ArgumentsBuilderBase<DeliveryFlatRateGroupConnection?, DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder>
    {
        protected override DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder Self => this;

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder(IQuery<DeliveryFlatRateGroupConnection?> query) : base(query)
        {
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}