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
    public sealed class CustomerWhatsAppMarketingConsentQueryBuilder : FieldsQueryBuilderBase<CustomerWhatsAppMarketingConsent, CustomerWhatsAppMarketingConsentQueryBuilder>
    {
        protected override CustomerWhatsAppMarketingConsentQueryBuilder Self => this;

        public CustomerWhatsAppMarketingConsentQueryBuilder() : this("customerWhatsAppMarketingConsent")
        {
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder(string name) : base(new Query<CustomerWhatsAppMarketingConsent>(name))
        {
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder(IQuery<CustomerWhatsAppMarketingConsent> query) : base(query)
        {
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder CollectedFrom()
        {
            base.InnerQuery.AddField("collectedFrom");
            return this;
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder OptInLevel()
        {
            base.InnerQuery.AddField("optInLevel");
            return this;
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder SourceLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("sourceLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }

        public CustomerWhatsAppMarketingConsentQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}