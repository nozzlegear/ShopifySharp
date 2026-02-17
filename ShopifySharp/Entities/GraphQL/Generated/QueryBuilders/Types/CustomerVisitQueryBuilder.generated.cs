#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CustomerVisitQueryBuilder : FieldsQueryBuilderBase<CustomerVisit, CustomerVisitQueryBuilder>
    {
        protected override CustomerVisitQueryBuilder Self => this;

        public CustomerVisitQueryBuilder() : this("customerVisit")
        {
        }

        public CustomerVisitQueryBuilder(string name) : base(new Query<CustomerVisit>(name))
        {
        }

        public CustomerVisitQueryBuilder(IQuery<CustomerVisit> query) : base(query)
        {
        }

        public CustomerVisitQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerVisitQueryBuilder LandingPage()
        {
            base.InnerQuery.AddField("landingPage");
            return this;
        }

        public CustomerVisitQueryBuilder LandingPageHtml()
        {
            base.InnerQuery.AddField("landingPageHtml");
            return this;
        }

        public CustomerVisitQueryBuilder MarketingEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder> build)
        {
            var query = new Query<MarketingEvent>("marketingEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEvent>(query);
            return this;
        }

        public CustomerVisitQueryBuilder OccurredAt()
        {
            base.InnerQuery.AddField("occurredAt");
            return this;
        }

        public CustomerVisitQueryBuilder ReferralCode()
        {
            base.InnerQuery.AddField("referralCode");
            return this;
        }

        public CustomerVisitQueryBuilder ReferralInfoHtml()
        {
            base.InnerQuery.AddField("referralInfoHtml");
            return this;
        }

        public CustomerVisitQueryBuilder ReferrerUrl()
        {
            base.InnerQuery.AddField("referrerUrl");
            return this;
        }

        public CustomerVisitQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public CustomerVisitQueryBuilder SourceDescription()
        {
            base.InnerQuery.AddField("sourceDescription");
            return this;
        }

        public CustomerVisitQueryBuilder SourceType()
        {
            base.InnerQuery.AddField("sourceType");
            return this;
        }

        public CustomerVisitQueryBuilder UtmParameters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder> build)
        {
            var query = new Query<UTMParameters>("utmParameters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UTMParametersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UTMParameters>(query);
            return this;
        }
    }
}