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

public class RefundQueryBuilder() : GraphQueryBuilder<Refund>("query refund")
{
    public RefundQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public RefundQueryBuilder AddFieldDuties()
    {
        AddField("duties");
        return this;
    }

    public RefundQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public RefundQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public RefundQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public RefundQueryBuilder AddFieldOrderAdjustments()
    {
        AddField("orderAdjustments");
        return this;
    }

    public RefundQueryBuilder AddFieldRefundLineItems()
    {
        AddField("refundLineItems");
        return this;
    }

    public RefundQueryBuilder AddFieldRefundShippingLines()
    {
        AddField("refundShippingLines");
        return this;
    }

    public RefundQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public RefundQueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }

    [Obsolete("Use `totalRefundedSet` instead.")]
    public RefundQueryBuilder AddFieldTotalRefunded()
    {
        AddField("totalRefunded");
        return this;
    }

    public RefundQueryBuilder AddFieldTotalRefundedSet()
    {
        AddField("totalRefundedSet");
        return this;
    }

    public RefundQueryBuilder AddFieldTransactions()
    {
        AddField("transactions");
        return this;
    }

    public RefundQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}