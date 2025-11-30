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

public class CheckoutBrandingDesignSystemQueryBuilder() : GraphQueryBuilder<CheckoutBrandingDesignSystem>("checkoutBrandingDesignSystem")
{
    public CheckoutBrandingDesignSystemQueryBuilder AddFieldColors(Func<CheckoutBrandingColorsQueryBuilder, CheckoutBrandingColorsQueryBuilder> build)
    {
        AddField<CheckoutBrandingColors, CheckoutBrandingColorsQueryBuilder>("colors", build);
        return this;
    }

    public CheckoutBrandingDesignSystemQueryBuilder AddFieldCornerRadius(Func<CheckoutBrandingCornerRadiusVariablesQueryBuilder, CheckoutBrandingCornerRadiusVariablesQueryBuilder> build)
    {
        AddField<CheckoutBrandingCornerRadiusVariables, CheckoutBrandingCornerRadiusVariablesQueryBuilder>("cornerRadius", build);
        return this;
    }

    public CheckoutBrandingDesignSystemQueryBuilder AddFieldTypography(Func<CheckoutBrandingTypographyQueryBuilder, CheckoutBrandingTypographyQueryBuilder> build)
    {
        AddField<CheckoutBrandingTypography, CheckoutBrandingTypographyQueryBuilder>("typography", build);
        return this;
    }
}