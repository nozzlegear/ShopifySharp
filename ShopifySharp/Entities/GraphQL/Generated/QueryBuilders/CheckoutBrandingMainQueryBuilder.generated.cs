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

public class CheckoutBrandingMainQueryBuilder() : GraphQueryBuilder<CheckoutBrandingMain>("checkoutBrandingMain")
{
    public CheckoutBrandingMainQueryBuilder AddFieldBackgroundImage(Func<CheckoutBrandingImageQueryBuilder, CheckoutBrandingImageQueryBuilder> build)
    {
        AddField<CheckoutBrandingImage, CheckoutBrandingImageQueryBuilder>("backgroundImage", build);
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldDivider(Func<CheckoutBrandingContainerDividerQueryBuilder, CheckoutBrandingContainerDividerQueryBuilder> build)
    {
        AddField<CheckoutBrandingContainerDivider, CheckoutBrandingContainerDividerQueryBuilder>("divider", build);
        return this;
    }

    public CheckoutBrandingMainQueryBuilder AddFieldSection(Func<CheckoutBrandingMainSectionQueryBuilder, CheckoutBrandingMainSectionQueryBuilder> build)
    {
        AddField<CheckoutBrandingMainSection, CheckoutBrandingMainSectionQueryBuilder>("section", build);
        return this;
    }
}