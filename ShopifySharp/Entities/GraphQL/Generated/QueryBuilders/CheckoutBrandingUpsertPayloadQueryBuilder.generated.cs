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

public class CheckoutBrandingUpsertPayloadQueryBuilder() : GraphQueryBuilder<CheckoutBrandingUpsertPayload>("checkoutBrandingUpsertPayload")
{
    public CheckoutBrandingUpsertPayloadQueryBuilder AddFieldCheckoutBranding(Func<CheckoutBrandingQueryBuilder, CheckoutBrandingQueryBuilder> build)
    {
        AddField<CheckoutBranding, CheckoutBrandingQueryBuilder>("checkoutBranding", build);
        return this;
    }

    public CheckoutBrandingUpsertPayloadQueryBuilder AddFieldUserErrors(Func<CheckoutBrandingUpsertUserErrorQueryBuilder, CheckoutBrandingUpsertUserErrorQueryBuilder> build)
    {
        AddField<CheckoutBrandingUpsertUserError, CheckoutBrandingUpsertUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}