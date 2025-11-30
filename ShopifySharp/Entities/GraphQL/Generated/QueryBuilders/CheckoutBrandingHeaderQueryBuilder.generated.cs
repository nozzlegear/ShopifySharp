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

public class CheckoutBrandingHeaderQueryBuilder() : GraphQueryBuilder<CheckoutBrandingHeader>("checkoutBrandingHeader")
{
    public CheckoutBrandingHeaderQueryBuilder AddFieldAlignment()
    {
        AddField("alignment");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldBanner(Func<CheckoutBrandingImageQueryBuilder, CheckoutBrandingImageQueryBuilder> build)
    {
        AddField<CheckoutBrandingImage, CheckoutBrandingImageQueryBuilder>("banner", build);
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldCartLink(Func<CheckoutBrandingHeaderCartLinkQueryBuilder, CheckoutBrandingHeaderCartLinkQueryBuilder> build)
    {
        AddField<CheckoutBrandingHeaderCartLink, CheckoutBrandingHeaderCartLinkQueryBuilder>("cartLink", build);
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldDivided()
    {
        AddField("divided");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldLogo(Func<CheckoutBrandingLogoQueryBuilder, CheckoutBrandingLogoQueryBuilder> build)
    {
        AddField<CheckoutBrandingLogo, CheckoutBrandingLogoQueryBuilder>("logo", build);
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldPadding()
    {
        AddField("padding");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }
}