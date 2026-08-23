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
    public sealed class ShippingConfigurationOptionDefinitionsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, ShippingConfigurationOptionDefinitionsCountArgumentsBuilder>
    {
        protected override ShippingConfigurationOptionDefinitionsCountArgumentsBuilder Self => this;

        public ShippingConfigurationOptionDefinitionsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public ShippingConfigurationOptionDefinitionsCountArgumentsBuilder Active(bool? active)
        {
            base.InnerQuery.AddArgument("active", active);
            return this;
        }
    }
}