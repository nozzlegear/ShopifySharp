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

public class CheckoutBrandingGlobalQueryBuilder() : GraphQueryBuilder<CheckoutBrandingGlobal>("checkoutBrandingGlobal")
{
    public CheckoutBrandingGlobalQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingGlobalQueryBuilder AddFieldTypography(Func<CheckoutBrandingTypographyStyleGlobalQueryBuilder, CheckoutBrandingTypographyStyleGlobalQueryBuilder> build)
    {
        AddField<CheckoutBrandingTypographyStyleGlobal, CheckoutBrandingTypographyStyleGlobalQueryBuilder>("typography", build);
        return this;
    }
}