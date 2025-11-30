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

public class OrderStagedChangeAddVariantQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddVariant>("orderStagedChangeAddVariant")
{
    public OrderStagedChangeAddVariantQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public OrderStagedChangeAddVariantQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }
}