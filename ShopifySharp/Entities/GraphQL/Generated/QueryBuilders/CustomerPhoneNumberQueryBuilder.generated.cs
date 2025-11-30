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

public class CustomerPhoneNumberQueryBuilder() : GraphQueryBuilder<CustomerPhoneNumber>("customerPhoneNumber")
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

    public CustomerPhoneNumberQueryBuilder AddFieldSourceLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("sourceLocation", build);
        return this;
    }
}