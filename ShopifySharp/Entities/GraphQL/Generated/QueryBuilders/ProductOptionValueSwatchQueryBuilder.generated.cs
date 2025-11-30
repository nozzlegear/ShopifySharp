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

public class ProductOptionValueSwatchQueryBuilder() : GraphQueryBuilder<ProductOptionValueSwatch>("productOptionValueSwatch")
{
    public ProductOptionValueSwatchQueryBuilder AddFieldColor()
    {
        AddField("color");
        return this;
    }

    public ProductOptionValueSwatchQueryBuilder AddFieldImage(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddField<MediaImage, MediaImageQueryBuilder>("image", build);
        return this;
    }
}