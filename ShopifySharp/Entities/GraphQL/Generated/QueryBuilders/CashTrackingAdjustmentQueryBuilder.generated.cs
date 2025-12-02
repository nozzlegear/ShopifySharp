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

public class CashTrackingAdjustmentQueryBuilder() : GraphQueryBuilder<CashTrackingAdjustment>("cashTrackingAdjustment")
{
    public CashTrackingAdjustmentQueryBuilder AddFieldCash(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("cash", build);
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

    public CashTrackingAdjustmentQueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }

    public CashTrackingAdjustmentQueryBuilder AddFieldTime()
    {
        AddField("time");
        return this;
    }
}