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

public class CustomerJourneySummaryQueryBuilder() : GraphQueryBuilder<CustomerJourneySummary>("query customerJourneySummary")
{
    public CustomerJourneySummaryQueryBuilder AddFieldCustomerOrderIndex()
    {
        AddField("customerOrderIndex");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldDaysToConversion()
    {
        AddField("daysToConversion");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldFirstVisit()
    {
        AddField("firstVisit");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldLastVisit()
    {
        AddField("lastVisit");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldMoments()
    {
        AddField("moments");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldMomentsCount()
    {
        AddField("momentsCount");
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldReady()
    {
        AddField("ready");
        return this;
    }
}