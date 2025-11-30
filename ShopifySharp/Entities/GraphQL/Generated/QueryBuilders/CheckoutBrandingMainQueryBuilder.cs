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

public class CheckoutBrandingMainQueryBuilder() : GraphQueryBuilder<CheckoutBrandingMain>("query checkoutBrandingMain")
{
    public CheckoutBrandingMainQueryBuilder AddFieldBackgroundImage()
    {
        AddField("backgroundImage");
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldDivider()
    {
        AddField("divider");
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldSection()
    {
        AddField("section");
        return this;
    }
}