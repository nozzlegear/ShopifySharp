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

public class OrderEditAddVariantQueryBuilder() : GraphQueryBuilder<OrderEditAddVariantPayload>("query orderEditAddVariant")
{
    public OrderEditAddVariantQueryBuilder AddArgumentAllowDuplicates(bool? allowDuplicates)
    {
        AddArgument("allowDuplicates", allowDuplicates);
        return this;
    }

    public OrderEditAddVariantQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditAddVariantQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }

    public OrderEditAddVariantQueryBuilder AddArgumentQuantity(int? quantity)
    {
        AddArgument("quantity", quantity);
        return this;
    }

    public OrderEditAddVariantQueryBuilder AddArgumentVariantId(string? variantId)
    {
        AddArgument("variantId", variantId);
        return this;
    }
}