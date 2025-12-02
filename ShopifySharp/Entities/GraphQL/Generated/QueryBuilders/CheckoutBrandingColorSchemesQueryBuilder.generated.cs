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

public class CheckoutBrandingColorSchemesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorSchemes>("checkoutBrandingColorSchemes")
{
    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme1(Func<CheckoutBrandingColorSchemeQueryBuilder, CheckoutBrandingColorSchemeQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorScheme, CheckoutBrandingColorSchemeQueryBuilder>("scheme1", build);
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme2(Func<CheckoutBrandingColorSchemeQueryBuilder, CheckoutBrandingColorSchemeQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorScheme, CheckoutBrandingColorSchemeQueryBuilder>("scheme2", build);
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme3(Func<CheckoutBrandingColorSchemeQueryBuilder, CheckoutBrandingColorSchemeQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorScheme, CheckoutBrandingColorSchemeQueryBuilder>("scheme3", build);
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme4(Func<CheckoutBrandingColorSchemeQueryBuilder, CheckoutBrandingColorSchemeQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorScheme, CheckoutBrandingColorSchemeQueryBuilder>("scheme4", build);
        return this;
    }
}