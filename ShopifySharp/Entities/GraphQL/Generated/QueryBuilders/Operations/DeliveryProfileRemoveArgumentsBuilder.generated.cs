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
    public sealed class DeliveryProfileRemoveArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileRemovePayload, DeliveryProfileRemoveArgumentsBuilder>
    {
        protected override DeliveryProfileRemoveArgumentsBuilder Self => this;

        public DeliveryProfileRemoveArgumentsBuilder(IQuery<DeliveryProfileRemovePayload> query) : base(query)
        {
        }

        public DeliveryProfileRemoveArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}