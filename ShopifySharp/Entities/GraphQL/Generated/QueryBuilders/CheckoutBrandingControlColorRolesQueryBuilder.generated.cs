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

public class CheckoutBrandingControlColorRolesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingControlColorRoles>("checkoutBrandingControlColorRoles")
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

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldSelected(Func<CheckoutBrandingColorRolesQueryBuilder, CheckoutBrandingColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorRoles, CheckoutBrandingColorRolesQueryBuilder>("selected", build);
        return this;
    }

    public CheckoutBrandingControlColorRolesQueryBuilder AddFieldText()
    {
        AddField("text");
        return this;
    }
}