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

public class DiscountAutomaticNodeQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNode>("discountAutomaticNode")
{
    public DiscountAutomaticNodeQueryBuilder AddUnionCaseAutomaticDiscount(Func<DiscountAutomaticAppQueryBuilder, DiscountAutomaticAppQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticApp, DiscountAutomaticAppQueryBuilder>("automaticDiscount", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddUnionCaseAutomaticDiscount(Func<DiscountAutomaticBasicQueryBuilder, DiscountAutomaticBasicQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBasic, DiscountAutomaticBasicQueryBuilder>("automaticDiscount", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddUnionCaseAutomaticDiscount(Func<DiscountAutomaticBxgyQueryBuilder, DiscountAutomaticBxgyQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBxgy, DiscountAutomaticBxgyQueryBuilder>("automaticDiscount", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddUnionCaseAutomaticDiscount(Func<DiscountAutomaticFreeShippingQueryBuilder, DiscountAutomaticFreeShippingQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticFreeShipping, DiscountAutomaticFreeShippingQueryBuilder>("automaticDiscount", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldEvents(Func<EventConnectionQueryBuilder, EventConnectionQueryBuilder> build)
    {
        AddField<EventConnection, EventConnectionQueryBuilder>("events", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldMetafieldDefinitions(Func<MetafieldDefinitionConnectionQueryBuilder, MetafieldDefinitionConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConnection, MetafieldDefinitionConnectionQueryBuilder>("metafieldDefinitions", build);
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }
}