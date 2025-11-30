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

public class CustomerJourneySummaryQueryBuilder() : GraphQueryBuilder<CustomerJourneySummary>("customerJourneySummary")
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

    public CustomerJourneySummaryQueryBuilder AddFieldFirstVisit(Func<CustomerVisitQueryBuilder, CustomerVisitQueryBuilder> build)
    {
        AddField<CustomerVisit, CustomerVisitQueryBuilder>("firstVisit", build);
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldLastVisit(Func<CustomerVisitQueryBuilder, CustomerVisitQueryBuilder> build)
    {
        AddField<CustomerVisit, CustomerVisitQueryBuilder>("lastVisit", build);
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldMoments(Func<CustomerMomentConnectionQueryBuilder, CustomerMomentConnectionQueryBuilder> build)
    {
        AddField<CustomerMomentConnection, CustomerMomentConnectionQueryBuilder>("moments", build);
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldMomentsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("momentsCount", build);
        return this;
    }

    public CustomerJourneySummaryQueryBuilder AddFieldReady()
    {
        AddField("ready");
        return this;
    }
}