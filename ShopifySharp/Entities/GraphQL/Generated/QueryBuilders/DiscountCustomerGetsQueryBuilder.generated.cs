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

public class DiscountCustomerGetsQueryBuilder() : GraphQueryBuilder<DiscountCustomerGets>("discountCustomerGets")
{
    public DiscountCustomerGetsQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseItems(Func<AllDiscountItemsQueryBuilder, AllDiscountItemsQueryBuilder> build)
    {
        AddUnion<AllDiscountItems, AllDiscountItemsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseItems(Func<DiscountCollectionsQueryBuilder, DiscountCollectionsQueryBuilder> build)
    {
        AddUnion<DiscountCollections, DiscountCollectionsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseItems(Func<DiscountProductsQueryBuilder, DiscountProductsQueryBuilder> build)
    {
        AddUnion<DiscountProducts, DiscountProductsQueryBuilder>("items", build);
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseValue(Func<DiscountAmountQueryBuilder, DiscountAmountQueryBuilder> build)
    {
        AddUnion<DiscountAmount, DiscountAmountQueryBuilder>("value", build);
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseValue(Func<DiscountOnQuantityQueryBuilder, DiscountOnQuantityQueryBuilder> build)
    {
        AddUnion<DiscountOnQuantity, DiscountOnQuantityQueryBuilder>("value", build);
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddUnionCaseValue(Func<DiscountPercentageQueryBuilder, DiscountPercentageQueryBuilder> build)
    {
        AddUnion<DiscountPercentage, DiscountPercentageQueryBuilder>("value", build);
        return this;
    }
}