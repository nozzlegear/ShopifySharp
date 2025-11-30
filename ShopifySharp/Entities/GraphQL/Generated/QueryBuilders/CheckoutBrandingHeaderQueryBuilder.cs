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

public class CheckoutBrandingHeaderQueryBuilder() : GraphQueryBuilder<CheckoutBrandingHeader>("query checkoutBrandingHeader")
{
    public CheckoutBrandingHeaderQueryBuilder AddFieldAlignment()
    {
        AddField("alignment");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldBanner()
    {
        AddField("banner");
        return this;
    }

    public CheckoutBrandingHeaderQueryBuilder AddFieldCartLink()
    {
        AddField("cartLink");
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

    public CheckoutBrandingHeaderQueryBuilder AddFieldLogo()
    {
        AddField("logo");
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