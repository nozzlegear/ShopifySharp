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

public class ProductVariantComponentQueryBuilder() : GraphQueryBuilder<ProductVariantComponent>("productVariantComponent")
{
    public ProductVariantComponentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductVariantComponentQueryBuilder AddFieldProductVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("productVariant", build);
        return this;
    }

    public ProductVariantComponentQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}