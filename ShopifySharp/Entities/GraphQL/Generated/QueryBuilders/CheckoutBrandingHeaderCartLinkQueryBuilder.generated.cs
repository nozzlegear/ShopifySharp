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

public class CheckoutBrandingHeaderCartLinkQueryBuilder() : GraphQueryBuilder<CheckoutBrandingHeaderCartLink>("checkoutBrandingHeaderCartLink")
{
    public CheckoutBrandingHeaderCartLinkQueryBuilder AddFieldContentType()
    {
        AddField("contentType");
        return this;
    }

    public CheckoutBrandingHeaderCartLinkQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }
}