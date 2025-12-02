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

public class CustomerEmailAddressQueryBuilder() : GraphQueryBuilder<CustomerEmailAddress>("customerEmailAddress")
{
    public CustomerEmailAddressQueryBuilder AddFieldEmailAddress()
    {
        AddField("emailAddress");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldMarketingOptInLevel()
    {
        AddField("marketingOptInLevel");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldMarketingState()
    {
        AddField("marketingState");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldMarketingUnsubscribeUrl()
    {
        AddField("marketingUnsubscribeUrl");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldMarketingUpdatedAt()
    {
        AddField("marketingUpdatedAt");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldOpenTrackingLevel()
    {
        AddField("openTrackingLevel");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldOpenTrackingUrl()
    {
        AddField("openTrackingUrl");
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldSourceLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("sourceLocation", build);
        return this;
    }

    public CustomerEmailAddressQueryBuilder AddFieldValidFormat()
    {
        AddField("validFormat");
        return this;
    }
}