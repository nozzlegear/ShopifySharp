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

public class CheckoutBrandingColorSchemeQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorScheme>("checkoutBrandingColorScheme")
{
    public CheckoutBrandingColorSchemeQueryBuilder AddFieldBase(Func<CheckoutBrandingColorRolesQueryBuilder, CheckoutBrandingColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingColorRoles, CheckoutBrandingColorRolesQueryBuilder>("base", build);
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldControl(Func<CheckoutBrandingControlColorRolesQueryBuilder, CheckoutBrandingControlColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingControlColorRoles, CheckoutBrandingControlColorRolesQueryBuilder>("control", build);
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldPrimaryButton(Func<CheckoutBrandingButtonColorRolesQueryBuilder, CheckoutBrandingButtonColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingButtonColorRoles, CheckoutBrandingButtonColorRolesQueryBuilder>("primaryButton", build);
        return this;
    }

    public CheckoutBrandingColorSchemeQueryBuilder AddFieldSecondaryButton(Func<CheckoutBrandingButtonColorRolesQueryBuilder, CheckoutBrandingButtonColorRolesQueryBuilder> build)
    {
        AddField<CheckoutBrandingButtonColorRoles, CheckoutBrandingButtonColorRolesQueryBuilder>("secondaryButton", build);
        return this;
    }
}