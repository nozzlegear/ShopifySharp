#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class OrderStagedChangeEdgeQueryBuilder() : GraphQueryBuilder<OrderStagedChangeEdge>("orderStagedChangeEdge")
{
    public OrderStagedChangeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeAddCustomItemQueryBuilder, OrderStagedChangeAddCustomItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddCustomItem, OrderStagedChangeAddCustomItemQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeAddLineItemDiscountQueryBuilder, OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddLineItemDiscount, OrderStagedChangeAddLineItemDiscountQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeAddShippingLineQueryBuilder, OrderStagedChangeAddShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddShippingLine, OrderStagedChangeAddShippingLineQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeAddVariantQueryBuilder, OrderStagedChangeAddVariantQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddVariant, OrderStagedChangeAddVariantQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeDecrementItemQueryBuilder, OrderStagedChangeDecrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeDecrementItem, OrderStagedChangeDecrementItemQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeIncrementItemQueryBuilder, OrderStagedChangeIncrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeIncrementItem, OrderStagedChangeIncrementItemQueryBuilder>("node", build);
        return this;
    }

    public OrderStagedChangeEdgeQueryBuilder AddUnionCaseNode(Func<OrderStagedChangeRemoveShippingLineQueryBuilder, OrderStagedChangeRemoveShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeRemoveShippingLine, OrderStagedChangeRemoveShippingLineQueryBuilder>("node", build);
        return this;
    }
}