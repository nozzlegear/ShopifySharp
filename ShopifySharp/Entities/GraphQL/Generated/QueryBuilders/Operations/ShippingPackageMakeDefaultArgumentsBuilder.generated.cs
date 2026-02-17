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
    public sealed class ShippingPackageMakeDefaultArgumentsBuilder : ArgumentsBuilderBase<ShippingPackageMakeDefaultPayload, ShippingPackageMakeDefaultArgumentsBuilder>
    {
        protected override ShippingPackageMakeDefaultArgumentsBuilder Self => this;

        public ShippingPackageMakeDefaultArgumentsBuilder(IQuery<ShippingPackageMakeDefaultPayload> query) : base(query)
        {
        }

        public ShippingPackageMakeDefaultArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}