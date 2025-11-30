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

public class InventoryTransferSetItemsQueryBuilder() : GraphQueryBuilder<InventoryTransferSetItemsPayload>("query inventoryTransferSetItems")
{
    public InventoryTransferSetItemsQueryBuilder AddArgumentInput(InventoryTransferSetItemsInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}