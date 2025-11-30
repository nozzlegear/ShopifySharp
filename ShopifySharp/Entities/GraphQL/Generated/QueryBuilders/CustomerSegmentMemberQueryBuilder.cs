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

public class CustomerSegmentMemberQueryBuilder() : GraphQueryBuilder<CustomerSegmentMember>("query customerSegmentMember")
{
    public CustomerSegmentMemberQueryBuilder AddFieldAmountSpent()
    {
        AddField("amountSpent");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultAddress()
    {
        AddField("defaultAddress");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultEmailAddress()
    {
        AddField("defaultEmailAddress");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultPhoneNumber()
    {
        AddField("defaultPhoneNumber");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldLastOrderId()
    {
        AddField("lastOrderId");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldMergeable()
    {
        AddField("mergeable");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldNumberOfOrders()
    {
        AddField("numberOfOrders");
        return this;
    }
}