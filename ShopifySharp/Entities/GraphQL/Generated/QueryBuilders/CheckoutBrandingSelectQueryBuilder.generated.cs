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

public class CheckoutBrandingSelectQueryBuilder() : GraphQueryBuilder<CheckoutBrandingSelect>("checkoutBrandingSelect")
{
    public CheckoutBrandingSelectQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingSelectQueryBuilder AddFieldTypography(Func<CheckoutBrandingTypographyStyleQueryBuilder, CheckoutBrandingTypographyStyleQueryBuilder> build)
    {
        AddField<CheckoutBrandingTypographyStyle, CheckoutBrandingTypographyStyleQueryBuilder>("typography", build);
        return this;
    }
}