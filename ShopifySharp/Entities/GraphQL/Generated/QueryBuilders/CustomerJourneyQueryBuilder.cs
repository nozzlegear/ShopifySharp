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

public class CustomerJourneyQueryBuilder() : GraphQueryBuilder<CustomerJourney>("query customerJourney")
{
    public CustomerJourneyQueryBuilder AddFieldCustomerOrderIndex()
    {
        AddField("customerOrderIndex");
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldDaysToConversion()
    {
        AddField("daysToConversion");
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldFirstVisit()
    {
        AddField("firstVisit");
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldLastVisit()
    {
        AddField("lastVisit");
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldMoments()
    {
        AddField("moments");
        return this;
    }
}