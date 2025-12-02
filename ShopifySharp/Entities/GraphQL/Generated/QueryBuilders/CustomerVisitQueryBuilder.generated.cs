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

public class CustomerVisitQueryBuilder() : GraphQueryBuilder<CustomerVisit>("customerVisit")
{
    public CustomerVisitQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldLandingPage()
    {
        AddField("landingPage");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldLandingPageHtml()
    {
        AddField("landingPageHtml");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldMarketingEvent(Func<MarketingEventQueryBuilder, MarketingEventQueryBuilder> build)
    {
        AddField<MarketingEvent, MarketingEventQueryBuilder>("marketingEvent", build);
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldOccurredAt()
    {
        AddField("occurredAt");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldReferralCode()
    {
        AddField("referralCode");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldReferralInfoHtml()
    {
        AddField("referralInfoHtml");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldReferrerUrl()
    {
        AddField("referrerUrl");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldSourceDescription()
    {
        AddField("sourceDescription");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldSourceType()
    {
        AddField("sourceType");
        return this;
    }

    public CustomerVisitQueryBuilder AddFieldUtmParameters(Func<UTMParametersQueryBuilder, UTMParametersQueryBuilder> build)
    {
        AddField<UTMParameters, UTMParametersQueryBuilder>("utmParameters", build);
        return this;
    }
}