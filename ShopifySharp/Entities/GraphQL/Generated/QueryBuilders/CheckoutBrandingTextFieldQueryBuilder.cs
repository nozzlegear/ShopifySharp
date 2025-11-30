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

public class CheckoutBrandingTextFieldQueryBuilder() : GraphQueryBuilder<CheckoutBrandingTextField>("query checkoutBrandingTextField")
{
    public CheckoutBrandingTextFieldQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingTextFieldQueryBuilder AddFieldTypography()
    {
        AddField("typography");
        return this;
    }
}