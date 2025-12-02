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

public class LineItemGroupQueryBuilder() : GraphQueryBuilder<LineItemGroup>("lineItemGroup")
{
    public LineItemGroupQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldProductId()
    {
        AddField("productId");
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldVariantId()
    {
        AddField("variantId");
        return this;
    }

    public LineItemGroupQueryBuilder AddFieldVariantSku()
    {
        AddField("variantSku");
        return this;
    }
}