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
    public sealed class ShippingPackageUpdateArgumentsBuilder : ArgumentsBuilderBase<ShippingPackageUpdatePayload, ShippingPackageUpdateArgumentsBuilder>
    {
        protected override ShippingPackageUpdateArgumentsBuilder Self => this;

        public ShippingPackageUpdateArgumentsBuilder(IQuery<ShippingPackageUpdatePayload> query) : base(query)
        {
        }

        public ShippingPackageUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ShippingPackageUpdateArgumentsBuilder ShippingPackage(CustomShippingPackageInput? shippingPackage)
        {
            base.InnerQuery.AddArgument("shippingPackage", shippingPackage);
            return this;
        }
    }
}