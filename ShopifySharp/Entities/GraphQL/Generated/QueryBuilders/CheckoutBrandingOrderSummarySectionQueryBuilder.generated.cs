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

public class CheckoutBrandingOrderSummarySectionQueryBuilder() : GraphQueryBuilder<CheckoutBrandingOrderSummarySection>("checkoutBrandingOrderSummarySection")
{
    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldBorderStyle()
    {
        AddField("borderStyle");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldBorderWidth()
    {
        AddField("borderWidth");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldPadding()
    {
        AddField("padding");
        return this;
    }

    public CheckoutBrandingOrderSummarySectionQueryBuilder AddFieldShadow()
    {
        AddField("shadow");
        return this;
    }
}