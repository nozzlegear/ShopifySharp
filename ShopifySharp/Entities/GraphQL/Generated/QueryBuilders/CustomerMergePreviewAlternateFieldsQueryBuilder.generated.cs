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

public class CustomerMergePreviewAlternateFieldsQueryBuilder() : GraphQueryBuilder<CustomerMergePreviewAlternateFields>("customerMergePreviewAlternateFields")
{
    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldDefaultAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("defaultAddress", build);
        return this;
    }

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldEmail(Func<CustomerEmailAddressQueryBuilder, CustomerEmailAddressQueryBuilder> build)
    {
        AddField<CustomerEmailAddress, CustomerEmailAddressQueryBuilder>("email", build);
        return this;
    }

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldPhoneNumber(Func<CustomerPhoneNumberQueryBuilder, CustomerPhoneNumberQueryBuilder> build)
    {
        AddField<CustomerPhoneNumber, CustomerPhoneNumberQueryBuilder>("phoneNumber", build);
        return this;
    }
}