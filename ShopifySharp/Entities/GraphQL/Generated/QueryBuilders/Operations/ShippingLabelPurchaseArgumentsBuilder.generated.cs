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
    public sealed class ShippingLabelPurchaseArgumentsBuilder : ArgumentsBuilderBase<ShippingLabelPurchasePayload, ShippingLabelPurchaseArgumentsBuilder>
    {
        protected override ShippingLabelPurchaseArgumentsBuilder Self => this;

        public ShippingLabelPurchaseArgumentsBuilder(IQuery<ShippingLabelPurchasePayload> query) : base(query)
        {
        }

        public ShippingLabelPurchaseArgumentsBuilder ShippingLabelPurchase(ShippingLabelPurchaseInput? shippingLabelPurchase)
        {
            base.InnerQuery.AddArgument("shippingLabelPurchase", shippingLabelPurchase);
            return this;
        }
    }
}