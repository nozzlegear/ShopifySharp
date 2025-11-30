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

public class CustomerPhoneNumberQueryBuilder() : GraphQueryBuilder<CustomerPhoneNumber>("query customerPhoneNumber")
{
    public CustomerPhoneNumberQueryBuilder AddFieldMarketingCollectedFrom()
    {
        AddField("marketingCollectedFrom");
        return this;
    }

    public CustomerPhoneNumberQueryBuilder AddFieldMarketingOptInLevel()
    {
        AddField("marketingOptInLevel");
        return this;
    }

    public CustomerPhoneNumberQueryBuilder AddFieldMarketingState()
    {
        AddField("marketingState");
        return this;
    }

    public CustomerPhoneNumberQueryBuilder AddFieldMarketingUpdatedAt()
    {
        AddField("marketingUpdatedAt");
        return this;
    }

    public CustomerPhoneNumberQueryBuilder AddFieldPhoneNumber()
    {
        AddField("phoneNumber");
        return this;
    }

    public CustomerPhoneNumberQueryBuilder AddFieldSourceLocation()
    {
        AddField("sourceLocation");
        return this;
    }
}