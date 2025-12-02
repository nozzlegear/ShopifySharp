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

public class CheckoutBrandingMainSectionQueryBuilder() : GraphQueryBuilder<CheckoutBrandingMainSection>("checkoutBrandingMainSection")
{
    public CheckoutBrandingMainSectionQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldBorderStyle()
    {
        AddField("borderStyle");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldBorderWidth()
    {
        AddField("borderWidth");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldPadding()
    {
        AddField("padding");
        return this;
    }

    public CheckoutBrandingMainSectionQueryBuilder AddFieldShadow()
    {
        AddField("shadow");
        return this;
    }
}