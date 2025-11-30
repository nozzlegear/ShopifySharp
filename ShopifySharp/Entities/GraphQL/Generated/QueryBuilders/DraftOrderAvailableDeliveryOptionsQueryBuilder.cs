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

public class DraftOrderAvailableDeliveryOptionsQueryBuilder() : GraphQueryBuilder<DraftOrderAvailableDeliveryOptions>("query draftOrderAvailableDeliveryOptions")
{
    public DraftOrderAvailableDeliveryOptionsQueryBuilder AddArgumentInput(DraftOrderAvailableDeliveryOptionsInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public DraftOrderAvailableDeliveryOptionsQueryBuilder AddArgumentLocalPickupCount(int? localPickupCount)
    {
        AddArgument("localPickupCount", localPickupCount);
        return this;
    }

    public DraftOrderAvailableDeliveryOptionsQueryBuilder AddArgumentLocalPickupFrom(int? localPickupFrom)
    {
        AddArgument("localPickupFrom", localPickupFrom);
        return this;
    }

    public DraftOrderAvailableDeliveryOptionsQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }

    public DraftOrderAvailableDeliveryOptionsQueryBuilder AddArgumentSessionToken(string? sessionToken)
    {
        AddArgument("sessionToken", sessionToken);
        return this;
    }
}