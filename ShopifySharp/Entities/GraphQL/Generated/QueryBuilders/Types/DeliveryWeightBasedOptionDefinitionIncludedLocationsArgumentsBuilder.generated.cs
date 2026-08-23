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
    public sealed class DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder>
    {
        protected override DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder Self => this;

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}