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

public class CheckoutBrandingButtonQueryBuilder() : GraphQueryBuilder<CheckoutBrandingButton>("query checkoutBrandingButton")
{
    public CheckoutBrandingButtonQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingButtonQueryBuilder AddFieldBlockPadding()
    {
        AddField("blockPadding");
        return this;
    }

    public CheckoutBrandingButtonQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingButtonQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingButtonQueryBuilder AddFieldInlinePadding()
    {
        AddField("inlinePadding");
        return this;
    }

    public CheckoutBrandingButtonQueryBuilder AddFieldTypography()
    {
        AddField("typography");
        return this;
    }
}