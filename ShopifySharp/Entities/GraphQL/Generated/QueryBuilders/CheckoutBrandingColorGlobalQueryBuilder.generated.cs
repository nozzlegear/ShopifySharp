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

public class CheckoutBrandingColorGlobalQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorGlobal>("checkoutBrandingColorGlobal")
{
    public CheckoutBrandingColorGlobalQueryBuilder AddFieldAccent()
    {
        AddField("accent");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldBrand()
    {
        AddField("brand");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldCritical()
    {
        AddField("critical");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldDecorative()
    {
        AddField("decorative");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldInfo()
    {
        AddField("info");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public CheckoutBrandingColorGlobalQueryBuilder AddFieldWarning()
    {
        AddField("warning");
        return this;
    }
}