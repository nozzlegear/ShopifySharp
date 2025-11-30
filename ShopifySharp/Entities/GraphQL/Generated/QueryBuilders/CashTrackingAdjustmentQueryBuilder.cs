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

public class CashTrackingAdjustmentQueryBuilder() : GraphQueryBuilder<CashTrackingAdjustment>("query cashTrackingAdjustment")
{
    public CashTrackingAdjustmentQueryBuilder AddFieldCash()
    {
        AddField("cash");
        return this;
    }

    public CashTrackingAdjustmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CashTrackingAdjustmentQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public CashTrackingAdjustmentQueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }

    public CashTrackingAdjustmentQueryBuilder AddFieldTime()
    {
        AddField("time");
        return this;
    }
}