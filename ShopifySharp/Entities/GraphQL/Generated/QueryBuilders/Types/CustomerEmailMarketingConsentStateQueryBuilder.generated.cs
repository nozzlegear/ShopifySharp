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
    public sealed class CustomerEmailMarketingConsentStateQueryBuilder : FieldsQueryBuilderBase<CustomerEmailMarketingConsentState, CustomerEmailMarketingConsentStateQueryBuilder>
    {
        protected override CustomerEmailMarketingConsentStateQueryBuilder Self => this;

        public CustomerEmailMarketingConsentStateQueryBuilder() : this("customerEmailMarketingConsentState")
        {
        }

        public CustomerEmailMarketingConsentStateQueryBuilder(string name) : base(new Query<CustomerEmailMarketingConsentState>(name))
        {
        }

        public CustomerEmailMarketingConsentStateQueryBuilder(IQuery<CustomerEmailMarketingConsentState> query) : base(query)
        {
        }

        public CustomerEmailMarketingConsentStateQueryBuilder ConsentUpdatedAt()
        {
            base.InnerQuery.AddField("consentUpdatedAt");
            return this;
        }

        public CustomerEmailMarketingConsentStateQueryBuilder MarketingOptInLevel()
        {
            base.InnerQuery.AddField("marketingOptInLevel");
            return this;
        }

        public CustomerEmailMarketingConsentStateQueryBuilder MarketingState()
        {
            base.InnerQuery.AddField("marketingState");
            return this;
        }

        public CustomerEmailMarketingConsentStateQueryBuilder SourceLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("sourceLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}