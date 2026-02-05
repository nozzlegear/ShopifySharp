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
    public sealed class CustomerSmsMarketingConsentUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerSmsMarketingConsentUpdatePayload, CustomerSmsMarketingConsentUpdatePayloadQueryBuilder>
    {
        protected override CustomerSmsMarketingConsentUpdatePayloadQueryBuilder Self => this;

        public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder() : this("customerSmsMarketingConsentUpdatePayload")
        {
        }

        public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder(string name) : base(new Query<CustomerSmsMarketingConsentUpdatePayload>(name))
        {
        }

        public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder(IQuery<CustomerSmsMarketingConsentUpdatePayload> query) : base(query)
        {
        }

        public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSmsMarketingConsentUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSmsMarketingConsentError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSmsMarketingConsentError>(query);
            return this;
        }
    }
}