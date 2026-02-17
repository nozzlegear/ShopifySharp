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
    public sealed class CarrierServiceDeleteArgumentsBuilder : ArgumentsBuilderBase<CarrierServiceDeletePayload, CarrierServiceDeleteArgumentsBuilder>
    {
        protected override CarrierServiceDeleteArgumentsBuilder Self => this;

        public CarrierServiceDeleteArgumentsBuilder(IQuery<CarrierServiceDeletePayload> query) : base(query)
        {
        }

        public CarrierServiceDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}