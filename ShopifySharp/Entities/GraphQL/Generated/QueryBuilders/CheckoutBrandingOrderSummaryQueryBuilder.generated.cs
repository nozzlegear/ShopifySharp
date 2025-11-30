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

public class CheckoutBrandingOrderSummaryQueryBuilder() : GraphQueryBuilder<CheckoutBrandingOrderSummary>("checkoutBrandingOrderSummary")
{
    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldBackgroundImage(Func<CheckoutBrandingImageQueryBuilder, CheckoutBrandingImageQueryBuilder> build)
    {
        AddField<CheckoutBrandingImage, CheckoutBrandingImageQueryBuilder>("backgroundImage", build);
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldDivider(Func<CheckoutBrandingContainerDividerQueryBuilder, CheckoutBrandingContainerDividerQueryBuilder> build)
    {
        AddField<CheckoutBrandingContainerDivider, CheckoutBrandingContainerDividerQueryBuilder>("divider", build);
        return this;
    }

    public CheckoutBrandingOrderSummaryQueryBuilder AddFieldSection(Func<CheckoutBrandingOrderSummarySectionQueryBuilder, CheckoutBrandingOrderSummarySectionQueryBuilder> build)
    {
        AddField<CheckoutBrandingOrderSummarySection, CheckoutBrandingOrderSummarySectionQueryBuilder>("section", build);
        return this;
    }
}