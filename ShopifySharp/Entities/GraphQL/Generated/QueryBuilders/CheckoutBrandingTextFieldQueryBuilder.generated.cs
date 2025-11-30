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

public class CheckoutBrandingTextFieldQueryBuilder() : GraphQueryBuilder<CheckoutBrandingTextField>("checkoutBrandingTextField")
{
    public CheckoutBrandingTextFieldQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingTextFieldQueryBuilder AddFieldTypography(Func<CheckoutBrandingTypographyStyleQueryBuilder, CheckoutBrandingTypographyStyleQueryBuilder> build)
    {
        AddField<CheckoutBrandingTypographyStyle, CheckoutBrandingTypographyStyleQueryBuilder>("typography", build);
        return this;
    }
}