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

public class CheckoutBrandingOrderSummaryQueryBuilder() : GraphQueryBuilder<CheckoutBrandingOrderSummary>("query checkoutBrandingOrderSummary")
{
    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldBackgroundImage()
    {
        AddField("backgroundImage");
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldDivider()
    {
        AddField("divider");
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldSection()
    {
        AddField("section");
        return this;
    }
}