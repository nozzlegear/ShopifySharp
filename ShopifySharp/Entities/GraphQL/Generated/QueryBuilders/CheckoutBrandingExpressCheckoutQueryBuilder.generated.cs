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

public class CheckoutBrandingExpressCheckoutQueryBuilder() : GraphQueryBuilder<CheckoutBrandingExpressCheckout>("checkoutBrandingExpressCheckout")
{
    public CheckoutBrandingExpressCheckoutQueryBuilder AddFieldButton(Func<CheckoutBrandingExpressCheckoutButtonQueryBuilder, CheckoutBrandingExpressCheckoutButtonQueryBuilder> build)
    {
        AddField<CheckoutBrandingExpressCheckoutButton, CheckoutBrandingExpressCheckoutButtonQueryBuilder>("button", build);
        return this;
    }
}