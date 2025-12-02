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

public class CheckoutBrandingColorsQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColors>("checkoutBrandingColors")
{
    public CheckoutBrandingColorsQueryBuilder AddFieldGlobal(Func<CheckoutBrandingColorGlobalQueryBuilder, CheckoutBrandingColorGlobalQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorGlobal, CheckoutBrandingColorGlobalQueryBuilder>("global", build);
        return this;
    }

    public CheckoutBrandingColorsQueryBuilder AddFieldSchemes(Func<CheckoutBrandingColorSchemesQueryBuilder, CheckoutBrandingColorSchemesQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorSchemes, CheckoutBrandingColorSchemesQueryBuilder>("schemes", build);
        return this;
    }
}