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

public class InventoryAdjustmentGroupQueryBuilder() : GraphQueryBuilder<InventoryAdjustmentGroup>("query inventoryAdjustmentGroup")
{
    public InventoryAdjustmentGroupQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldChanges()
    {
        AddField("changes");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldReferenceDocumentUri()
    {
        AddField("referenceDocumentUri");
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }
}