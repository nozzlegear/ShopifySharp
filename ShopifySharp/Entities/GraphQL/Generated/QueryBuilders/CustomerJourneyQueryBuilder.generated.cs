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

public class CustomerJourneyQueryBuilder() : GraphQueryBuilder<CustomerJourney>("customerJourney")
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

    public CustomerJourneyQueryBuilder AddFieldFirstVisit(Func<CustomerVisitQueryBuilder, CustomerVisitQueryBuilder> build)
    {
        AddField<CustomerVisit, CustomerVisitQueryBuilder>("firstVisit", build);
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldLastVisit(Func<CustomerVisitQueryBuilder, CustomerVisitQueryBuilder> build)
    {
        AddField<CustomerVisit, CustomerVisitQueryBuilder>("lastVisit", build);
        return this;
    }

    public CustomerJourneyQueryBuilder AddFieldMoments(Func<CustomerMomentQueryBuilder, CustomerMomentQueryBuilder> build)
    {
        AddField<ICustomerMoment, CustomerMomentQueryBuilder>("moments", build);
        return this;
    }
}