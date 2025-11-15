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

public class CustomerMergePreviewAlternateFieldsQueryBuilder() : GraphQueryBuilder<CustomerMergePreviewAlternateFields>("query customerMergePreviewAlternateFields")
{
    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldDefaultAddress()
    {
        AddField("defaultAddress");
        return this;
    }

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldEmail()
    {
        AddField("email");
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

    public CustomerMergePreviewAlternateFieldsQueryBuilder AddFieldPhoneNumber()
    {
        AddField("phoneNumber");
        return this;
    }
}