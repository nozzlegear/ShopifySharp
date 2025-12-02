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

public class DiscountCustomerBuysQueryBuilder() : GraphQueryBuilder<DiscountCustomerBuys>("discountCustomerBuys")
{
    public DiscountCustomerBuysQueryBuilder AddFieldIsOneTimePurchase()
    {
        AddField("isOneTimePurchase");
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddFieldIsSubscription()
    {
        AddField("isSubscription");
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddUnionCaseItems(Func<AllDiscountItemsQueryBuilder, AllDiscountItemsQueryBuilder> build)
    {
        AddUnion<AllDiscountItems, AllDiscountItemsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddUnionCaseItems(Func<DiscountCollectionsQueryBuilder, DiscountCollectionsQueryBuilder> build)
    {
        AddUnion<DiscountCollections, DiscountCollectionsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddUnionCaseItems(Func<DiscountProductsQueryBuilder, DiscountProductsQueryBuilder> build)
    {
        AddUnion<DiscountProducts, DiscountProductsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddUnionCaseValue(Func<DiscountPurchaseAmountQueryBuilder, DiscountPurchaseAmountQueryBuilder> build)
    {
        AddUnion<DiscountPurchaseAmount, DiscountPurchaseAmountQueryBuilder>("value", build);
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddUnionCaseValue(Func<DiscountQuantityQueryBuilder, DiscountQuantityQueryBuilder> build)
    {
        AddUnion<DiscountQuantity, DiscountQuantityQueryBuilder>("value", build);
        return this;
    }
}