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

public class CheckoutBrandingColorRolesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorRoles>("query checkoutBrandingColorRoles")
{
    public CheckoutBrandingColorRolesQueryBuilder AddFieldAccent()
    {
        AddField("accent");
        return this;
    }

    public CheckoutBrandingColorRolesQueryBuilder AddFieldBackground()
    {
        AddField("background");
        return this;
    }

    public CheckoutBrandingColorRolesQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingColorRolesQueryBuilder AddFieldDecorative()
    {
        AddField("decorative");
        return this;
    }

    public CheckoutBrandingColorRolesQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public CheckoutBrandingColorRolesQueryBuilder AddFieldText()
    {
        AddField("text");
        return this;
    }
}