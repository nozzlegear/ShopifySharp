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

public class CheckoutBrandingContainerDividerQueryBuilder() : GraphQueryBuilder<CheckoutBrandingContainerDivider>("checkoutBrandingContainerDivider")
{
    public CheckoutBrandingContainerDividerQueryBuilder AddFieldBorderStyle()
    {
        AddField("borderStyle");
        return this;
    }

    public CheckoutBrandingContainerDividerQueryBuilder AddFieldBorderWidth()
    {
        AddField("borderWidth");
        return this;
    }

    public CheckoutBrandingContainerDividerQueryBuilder AddFieldVisibility()
    {
        AddField("visibility");
        return this;
    }
}