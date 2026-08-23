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
    public sealed class DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder : ArgumentsBuilderBase<LocationConnection?, DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder>
    {
        protected override DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder Self => this;

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder(IQuery<LocationConnection?> query) : base(query)
        {
        }

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryOptionDefinitionIncludedLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}