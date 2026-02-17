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
    public sealed class CarrierServiceUpdateArgumentsBuilder : ArgumentsBuilderBase<CarrierServiceUpdatePayload, CarrierServiceUpdateArgumentsBuilder>
    {
        protected override CarrierServiceUpdateArgumentsBuilder Self => this;

        public CarrierServiceUpdateArgumentsBuilder(IQuery<CarrierServiceUpdatePayload> query) : base(query)
        {
        }

        public CarrierServiceUpdateArgumentsBuilder Input(DeliveryCarrierServiceUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}