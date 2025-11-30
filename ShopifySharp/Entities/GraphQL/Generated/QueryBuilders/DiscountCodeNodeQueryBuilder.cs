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

public class DiscountCodeNodeQueryBuilder() : GraphQueryBuilder<DiscountCodeNode>("query discountCodeNode")
{
    public DiscountCodeNodeQueryBuilder AddFieldCodeDiscount()
    {
        AddField("codeDiscount");
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldEvents()
    {
        AddField("events");
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public DiscountCodeNodeQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }

    public DiscountCodeNodeQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }
}