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

public class CheckoutBrandingFooterQueryBuilder() : GraphQueryBuilder<CheckoutBrandingFooter>("checkoutBrandingFooter")
{
    public CheckoutBrandingFooterQueryBuilder AddFieldAlignment()
    {
        AddField("alignment");
        return this;
    }

    public CheckoutBrandingFooterQueryBuilder AddFieldColorScheme()
    {
        AddField("colorScheme");
        return this;
    }

    public CheckoutBrandingFooterQueryBuilder AddFieldContent(Func<CheckoutBrandingFooterContentQueryBuilder, CheckoutBrandingFooterContentQueryBuilder> build)
    {
        AddField<CheckoutBrandingFooterContent, CheckoutBrandingFooterContentQueryBuilder>("content", build);
        return this;
    }

    public CheckoutBrandingFooterQueryBuilder AddFieldDivided()
    {
        AddField("divided");
        return this;
    }

    public CheckoutBrandingFooterQueryBuilder AddFieldPadding()
    {
        AddField("padding");
        return this;
    }

    public CheckoutBrandingFooterQueryBuilder AddFieldPosition()
    {
        AddField("position");
        return this;
    }
}