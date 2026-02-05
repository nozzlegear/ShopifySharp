#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ReverseDeliveryArgumentsBuilder : ArgumentsBuilderBase<ReverseDelivery, ReverseDeliveryArgumentsBuilder>
    {
        protected override ReverseDeliveryArgumentsBuilder Self => this;

        public ReverseDeliveryArgumentsBuilder(IQuery<ReverseDelivery> query) : base(query)
        {
        }

        public ReverseDeliveryArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}