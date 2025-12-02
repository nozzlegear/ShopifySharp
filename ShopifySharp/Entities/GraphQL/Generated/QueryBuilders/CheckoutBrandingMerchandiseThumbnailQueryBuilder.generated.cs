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

public class CheckoutBrandingMerchandiseThumbnailQueryBuilder() : GraphQueryBuilder<CheckoutBrandingMerchandiseThumbnail>("checkoutBrandingMerchandiseThumbnail")
{
    public CheckoutBrandingMerchandiseThumbnailQueryBuilder AddFieldBadge(Func<CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder, CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder> build)
    {
        AddField<CheckoutBrandingMerchandiseThumbnailBadge, CheckoutBrandingMerchandiseThumbnailBadgeQueryBuilder>("badge", build);
        return this;
    }

    public CheckoutBrandingMerchandiseThumbnailQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingMerchandiseThumbnailQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingMerchandiseThumbnailQueryBuilder AddFieldFit()
    {
        AddField("fit");
        return this;
    }
}