#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CustomerSmsMarketingConsentStateQueryBuilder : FieldsQueryBuilderBase<CustomerSmsMarketingConsentState, CustomerSmsMarketingConsentStateQueryBuilder>
    {
        protected override CustomerSmsMarketingConsentStateQueryBuilder Self => this;

        public CustomerSmsMarketingConsentStateQueryBuilder() : this("customerSmsMarketingConsentState")
        {
        }

        public CustomerSmsMarketingConsentStateQueryBuilder(string name) : base(new Query<CustomerSmsMarketingConsentState>(name))
        {
        }

        public CustomerSmsMarketingConsentStateQueryBuilder(IQuery<CustomerSmsMarketingConsentState> query) : base(query)
        {
        }

        public CustomerSmsMarketingConsentStateQueryBuilder ConsentCollectedFrom()
        {
            base.InnerQuery.AddField("consentCollectedFrom");
            return this;
        }

        public CustomerSmsMarketingConsentStateQueryBuilder ConsentUpdatedAt()
        {
            base.InnerQuery.AddField("consentUpdatedAt");
            return this;
        }

        public CustomerSmsMarketingConsentStateQueryBuilder MarketingOptInLevel()
        {
            base.InnerQuery.AddField("marketingOptInLevel");
            return this;
        }

        public CustomerSmsMarketingConsentStateQueryBuilder MarketingState()
        {
            base.InnerQuery.AddField("marketingState");
            return this;
        }

        public CustomerSmsMarketingConsentStateQueryBuilder SourceLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("sourceLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}