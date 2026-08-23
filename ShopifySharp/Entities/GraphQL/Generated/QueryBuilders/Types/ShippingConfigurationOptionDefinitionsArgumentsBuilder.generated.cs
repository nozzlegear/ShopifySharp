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
    public sealed class ShippingConfigurationOptionDefinitionsArgumentsBuilder : ArgumentsBuilderBase<DeliveryOptionDefinitionConnection?, ShippingConfigurationOptionDefinitionsArgumentsBuilder>
    {
        protected override ShippingConfigurationOptionDefinitionsArgumentsBuilder Self => this;

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder(IQuery<DeliveryOptionDefinitionConnection?> query) : base(query)
        {
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder Active(bool? active)
        {
            base.InnerQuery.AddArgument("active", active);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShippingConfigurationOptionDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}