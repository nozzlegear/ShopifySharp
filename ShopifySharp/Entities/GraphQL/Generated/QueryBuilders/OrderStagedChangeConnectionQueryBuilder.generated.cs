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

public class OrderStagedChangeConnectionQueryBuilder() : GraphQueryBuilder<OrderStagedChangeConnection>("orderStagedChangeConnection")
{
    public OrderStagedChangeConnectionQueryBuilder AddFieldEdges(Func<OrderStagedChangeEdgeQueryBuilder, OrderStagedChangeEdgeQueryBuilder> build)
    {
        AddField<OrderStagedChangeEdge, OrderStagedChangeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeAddCustomItemQueryBuilder, OrderStagedChangeAddCustomItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddCustomItem, OrderStagedChangeAddCustomItemQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeAddLineItemDiscountQueryBuilder, OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddLineItemDiscount, OrderStagedChangeAddLineItemDiscountQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeAddShippingLineQueryBuilder, OrderStagedChangeAddShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddShippingLine, OrderStagedChangeAddShippingLineQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeAddVariantQueryBuilder, OrderStagedChangeAddVariantQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddVariant, OrderStagedChangeAddVariantQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeDecrementItemQueryBuilder, OrderStagedChangeDecrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeDecrementItem, OrderStagedChangeDecrementItemQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeIncrementItemQueryBuilder, OrderStagedChangeIncrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeIncrementItem, OrderStagedChangeIncrementItemQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddUnionCaseNodes(Func<OrderStagedChangeRemoveShippingLineQueryBuilder, OrderStagedChangeRemoveShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeRemoveShippingLine, OrderStagedChangeRemoveShippingLineQueryBuilder>("nodes", build);
        return this;
    }

    public OrderStagedChangeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}