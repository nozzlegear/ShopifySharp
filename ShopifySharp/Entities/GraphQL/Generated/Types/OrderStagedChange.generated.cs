#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A change that has been applied to an order.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<OrderStagedChange>))]
public record OrderStagedChange : GraphQLObject<OrderStagedChange>, IGraphQLUnionType
{
    public OrderStagedChangeAddCustomItem? AsOrderStagedChangeAddCustomItem() => this is OrderStagedChangeOrderStagedChangeAddCustomItem wrapper ? wrapper.Value : null;
    public OrderStagedChangeAddLineItemDiscount? AsOrderStagedChangeAddLineItemDiscount() => this is OrderStagedChangeOrderStagedChangeAddLineItemDiscount wrapper ? wrapper.Value : null;
    public OrderStagedChangeAddShippingLine? AsOrderStagedChangeAddShippingLine() => this is OrderStagedChangeOrderStagedChangeAddShippingLine wrapper ? wrapper.Value : null;
    public OrderStagedChangeAddVariant? AsOrderStagedChangeAddVariant() => this is OrderStagedChangeOrderStagedChangeAddVariant wrapper ? wrapper.Value : null;
    public OrderStagedChangeDecrementItem? AsOrderStagedChangeDecrementItem() => this is OrderStagedChangeOrderStagedChangeDecrementItem wrapper ? wrapper.Value : null;
    public OrderStagedChangeIncrementItem? AsOrderStagedChangeIncrementItem() => this is OrderStagedChangeOrderStagedChangeIncrementItem wrapper ? wrapper.Value : null;
    public OrderStagedChangeRemoveDiscount? AsOrderStagedChangeRemoveDiscount() => this is OrderStagedChangeOrderStagedChangeRemoveDiscount wrapper ? wrapper.Value : null;
    public OrderStagedChangeRemoveShippingLine? AsOrderStagedChangeRemoveShippingLine() => this is OrderStagedChangeOrderStagedChangeRemoveShippingLine wrapper ? wrapper.Value : null;
}