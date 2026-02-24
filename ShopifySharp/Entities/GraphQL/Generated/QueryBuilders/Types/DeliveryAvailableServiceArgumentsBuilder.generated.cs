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
    public sealed class DeliveryAvailableServiceArgumentsBuilder : ArgumentsBuilderBase<DeliveryAvailableService, DeliveryAvailableServiceArgumentsBuilder>
    {
        protected override DeliveryAvailableServiceArgumentsBuilder Self => this;

        public DeliveryAvailableServiceArgumentsBuilder(IQuery<DeliveryAvailableService> query) : base(query)
        {
        }

        public DeliveryAvailableServiceArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public DeliveryAvailableServiceArgumentsBuilder Origins(ICollection<string>? origins)
        {
            base.InnerQuery.AddArgument("origins", origins);
            return this;
        }

        public DeliveryAvailableServiceArgumentsBuilder RestOfWorld(bool? restOfWorld)
        {
            base.InnerQuery.AddArgument("restOfWorld", restOfWorld);
            return this;
        }
    }
}