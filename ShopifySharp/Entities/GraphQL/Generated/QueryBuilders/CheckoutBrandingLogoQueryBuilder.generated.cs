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

public class CheckoutBrandingLogoQueryBuilder() : GraphQueryBuilder<CheckoutBrandingLogo>("checkoutBrandingLogo")
{
    public CheckoutBrandingLogoQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public CheckoutBrandingLogoQueryBuilder AddFieldMaxWidth()
    {
        AddField("maxWidth");
        return this;
    }

    public CheckoutBrandingLogoQueryBuilder AddFieldVisibility()
    {
        AddField("visibility");
        return this;
    }
}