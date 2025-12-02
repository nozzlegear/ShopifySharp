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

public class CustomerMergePreviewDefaultFieldsQueryBuilder() : GraphQueryBuilder<CustomerMergePreviewDefaultFields>("customerMergePreviewDefaultFields")
{
    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldAddresses(Func<MailingAddressConnectionQueryBuilder, MailingAddressConnectionQueryBuilder> build)
    {
        AddField<MailingAddressConnection, MailingAddressConnectionQueryBuilder>("addresses", build);
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDefaultAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("defaultAddress", build);
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDiscountNodeCount()
    {
        AddField("discountNodeCount");
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDiscountNodes(Func<DiscountNodeConnectionQueryBuilder, DiscountNodeConnectionQueryBuilder> build)
    {
        AddField<DiscountNodeConnection, DiscountNodeConnectionQueryBuilder>("discountNodes", build);
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

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldDraftOrders(Func<DraftOrderConnectionQueryBuilder, DraftOrderConnectionQueryBuilder> build)
    {
        AddField<DraftOrderConnection, DraftOrderConnectionQueryBuilder>("draftOrders", build);
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldEmail(Func<CustomerEmailAddressQueryBuilder, CustomerEmailAddressQueryBuilder> build)
    {
        AddField<CustomerEmailAddress, CustomerEmailAddressQueryBuilder>("email", build);
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

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldGiftCards(Func<GiftCardConnectionQueryBuilder, GiftCardConnectionQueryBuilder> build)
    {
        AddField<GiftCardConnection, GiftCardConnectionQueryBuilder>("giftCards", build);
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

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldOrders(Func<OrderConnectionQueryBuilder, OrderConnectionQueryBuilder> build)
    {
        AddField<OrderConnection, OrderConnectionQueryBuilder>("orders", build);
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldPhoneNumber(Func<CustomerPhoneNumberQueryBuilder, CustomerPhoneNumberQueryBuilder> build)
    {
        AddField<CustomerPhoneNumber, CustomerPhoneNumberQueryBuilder>("phoneNumber", build);
        return this;
    }

    public CustomerMergePreviewDefaultFieldsQueryBuilder AddFieldTags()
    {
        AddField("tags");
        return this;
    }
}