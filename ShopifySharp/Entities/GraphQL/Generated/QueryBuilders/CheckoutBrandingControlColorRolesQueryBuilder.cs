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

public class CheckoutBrandingControlColorRolesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingControlColorRoles>("query checkoutBrandingControlColorRoles")
{
    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldAccent()
    {
        AddField("accent");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldDecorative()
    {
        AddField("decorative");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldSelected()
    {
        AddField("selected");
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldText()
    {
        AddField("text");
        return this;
    }
}