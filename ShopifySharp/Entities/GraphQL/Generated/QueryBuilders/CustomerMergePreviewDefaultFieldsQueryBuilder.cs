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

public class CustomerMergePreviewDefaultFieldsQueryBuilder() : GraphQueryBuilder<CustomerMergePreviewDefaultFields>("query customerMergePreviewDefaultFields")
{
    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldAddresses()
    {
        AddField("addresses");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDefaultAddress()
    {
        AddField("defaultAddress");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDiscountNodeCount()
    {
        AddField("discountNodeCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDiscountNodes()
    {
        AddField("discountNodes");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDraftOrderCount()
    {
        AddField("draftOrderCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDraftOrders()
    {
        AddField("draftOrders");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldGiftCardCount()
    {
        AddField("giftCardCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldGiftCards()
    {
        AddField("giftCards");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldMetafieldCount()
    {
        AddField("metafieldCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldOrderCount()
    {
        AddField("orderCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldPhoneNumber()
    {
        AddField("phoneNumber");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldTags()
    {
        AddField("tags");
        return this;
    }
}