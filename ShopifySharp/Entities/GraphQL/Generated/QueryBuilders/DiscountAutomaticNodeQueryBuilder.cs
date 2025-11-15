#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DiscountAutomaticNodeQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNode>("query discountAutomaticNode")
{
    public DiscountAutomaticNodeQueryBuilder AddFieldAutomaticDiscount()
    {
        AddField("automaticDiscount");
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldEvents()
    {
        AddField("events");
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public DiscountAutomaticNodeQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }

    public DiscountAutomaticNodeQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }
}