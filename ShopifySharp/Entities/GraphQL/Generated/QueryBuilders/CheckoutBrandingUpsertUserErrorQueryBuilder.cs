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

public class CheckoutBrandingUpsertUserErrorQueryBuilder() : GraphQueryBuilder<CheckoutBrandingUpsertUserError>("query checkoutBrandingUpsertUserError")
{
    public CheckoutBrandingUpsertUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CheckoutBrandingUpsertUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CheckoutBrandingUpsertUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}