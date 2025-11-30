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

public class CustomerSegmentMemberQueryBuilder() : GraphQueryBuilder<CustomerSegmentMember>("customerSegmentMember")
{
    public CustomerSegmentMemberQueryBuilder AddFieldAmountSpent(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amountSpent", build);
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("defaultAddress", build);
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultEmailAddress(Func<CustomerEmailAddressQueryBuilder, CustomerEmailAddressQueryBuilder> build)
    {
        AddField<CustomerEmailAddress, CustomerEmailAddressQueryBuilder>("defaultEmailAddress", build);
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldDefaultPhoneNumber(Func<CustomerPhoneNumberQueryBuilder, CustomerPhoneNumberQueryBuilder> build)
    {
        AddField<CustomerPhoneNumber, CustomerPhoneNumberQueryBuilder>("defaultPhoneNumber", build);
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

    public CustomerSegmentMemberQueryBuilder AddFieldMergeable(Func<CustomerMergeableQueryBuilder, CustomerMergeableQueryBuilder> build)
    {
        AddField<CustomerMergeable, CustomerMergeableQueryBuilder>("mergeable", build);
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public CustomerSegmentMemberQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
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