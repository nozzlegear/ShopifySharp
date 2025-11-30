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

public class InventoryAdjustmentGroupQueryBuilder() : GraphQueryBuilder<InventoryAdjustmentGroup>("inventoryAdjustmentGroup")
{
    public InventoryAdjustmentGroupQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public InventoryAdjustmentGroupQueryBuilder AddFieldChanges(Func<InventoryChangeQueryBuilder, InventoryChangeQueryBuilder> build)
    {
        AddField<InventoryChange, InventoryChangeQueryBuilder>("changes", build);
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

    public InventoryAdjustmentGroupQueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }
}