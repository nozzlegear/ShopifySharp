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

public class CheckoutBrandingButtonColorRolesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingButtonColorRoles>("checkoutBrandingButtonColorRoles")
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

    public CheckoutBrandingButtonColorRolesQueryBuilder AddFieldHover(Func<CheckoutBrandingColorRolesQueryBuilder, CheckoutBrandingColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorRoles, CheckoutBrandingColorRolesQueryBuilder>("hover", build);
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