#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CheckoutBrandingColorSchemeQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorScheme>("query checkoutBrandingColorScheme")
{
    public CheckoutBrandingColorSchemeQueryBuilder AddFieldBase()
    {
        AddField("base");
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldControl()
    {
        AddField("control");
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldPrimaryButton()
    {
        AddField("primaryButton");
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldSecondaryButton()
    {
        AddField("secondaryButton");
        return this;
    }
}