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

public class CheckoutBrandingButtonColorRolesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingButtonColorRoles>("query checkoutBrandingButtonColorRoles")
{
    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldAccent()
    {
        AddField("accent");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldDecorative()
    {
        AddField("decorative");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldHover()
    {
        AddField("hover");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldText()
    {
        AddField("text");
        return this;
    }
}