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

public class OrderEditAddCustomItemQueryBuilder() : GraphQueryBuilder<OrderEditAddCustomItemPayload>("query orderEditAddCustomItem")
{
    public OrderEditAddCustomItemQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentPrice(MoneyInput? price)
    {
        AddArgument("price", price);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentQuantity(int? quantity)
    {
        AddArgument("quantity", quantity);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentRequiresShipping(bool? requiresShipping)
    {
        AddArgument("requiresShipping", requiresShipping);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentTaxable(bool? taxable)
    {
        AddArgument("taxable", taxable);
        return this;
    }

    public OrderEditAddCustomItemQueryBuilder AddArgumentTitle(string? title)
    {
        AddArgument("title", title);
        return this;
    }
}