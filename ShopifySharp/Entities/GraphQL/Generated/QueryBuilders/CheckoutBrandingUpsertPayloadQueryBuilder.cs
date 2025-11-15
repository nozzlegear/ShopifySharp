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

public class CheckoutBrandingUpsertPayloadQueryBuilder() : GraphQueryBuilder<CheckoutBrandingUpsertPayload>("query checkoutBrandingUpsertPayload")
{
    public CheckoutBrandingUpsertPayloadQueryBuilder AddFieldCheckoutBranding()
    {
        AddField("checkoutBranding");
        return this;
    }

    public CheckoutBrandingUpsertPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}