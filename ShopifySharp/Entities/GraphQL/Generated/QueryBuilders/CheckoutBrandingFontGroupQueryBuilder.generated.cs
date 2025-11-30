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

public class CheckoutBrandingFontGroupQueryBuilder() : GraphQueryBuilder<CheckoutBrandingFontGroup>("checkoutBrandingFontGroup")
{
    public CheckoutBrandingFontGroupQueryBuilder AddFieldBase(Func<CheckoutBrandingFontQueryBuilder, CheckoutBrandingFontQueryBuilder> build)
    {
        AddField<ICheckoutBrandingFont, CheckoutBrandingFontQueryBuilder>("base", build);
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldBold(Func<CheckoutBrandingFontQueryBuilder, CheckoutBrandingFontQueryBuilder> build)
    {
        AddField<ICheckoutBrandingFont, CheckoutBrandingFontQueryBuilder>("bold", build);
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldLoadingStrategy()
    {
        AddField("loadingStrategy");
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}