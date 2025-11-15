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

public class InventoryTransferEditQueryBuilder() : GraphQueryBuilder<InventoryTransferEditPayload>("query inventoryTransferEdit")
{
    public InventoryTransferEditQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryTransferEditQueryBuilder AddArgumentInput(InventoryTransferEditInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}