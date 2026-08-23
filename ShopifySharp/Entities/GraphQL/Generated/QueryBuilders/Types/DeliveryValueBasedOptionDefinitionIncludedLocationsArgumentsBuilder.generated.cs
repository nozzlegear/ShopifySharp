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
    public sealed class DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder>
    {
        protected override DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder Self => this;

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionIncludedLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}