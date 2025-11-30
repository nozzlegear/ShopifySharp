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

public class CheckoutBrandingTypographyQueryBuilder() : GraphQueryBuilder<CheckoutBrandingTypography>("checkoutBrandingTypography")
{
    public CheckoutBrandingTypographyQueryBuilder AddFieldPrimary(Func<CheckoutBrandingFontGroupQueryBuilder, CheckoutBrandingFontGroupQueryBuilder> build)
    {
        AddField<CheckoutBrandingFontGroup, CheckoutBrandingFontGroupQueryBuilder>("primary", build);
        return this;
    }

    public CheckoutBrandingTypographyQueryBuilder AddFieldSecondary(Func<CheckoutBrandingFontGroupQueryBuilder, CheckoutBrandingFontGroupQueryBuilder> build)
    {
        AddField<CheckoutBrandingFontGroup, CheckoutBrandingFontGroupQueryBuilder>("secondary", build);
        return this;
    }

    public CheckoutBrandingTypographyQueryBuilder AddFieldSize(Func<CheckoutBrandingFontSizeQueryBuilder, CheckoutBrandingFontSizeQueryBuilder> build)
    {
        AddField<CheckoutBrandingFontSize, CheckoutBrandingFontSizeQueryBuilder>("size", build);
        return this;
    }
}