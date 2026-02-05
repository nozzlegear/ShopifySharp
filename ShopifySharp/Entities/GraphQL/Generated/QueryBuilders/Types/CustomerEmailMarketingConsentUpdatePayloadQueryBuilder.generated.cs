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
    public sealed class CustomerEmailMarketingConsentUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerEmailMarketingConsentUpdatePayload, CustomerEmailMarketingConsentUpdatePayloadQueryBuilder>
    {
        protected override CustomerEmailMarketingConsentUpdatePayloadQueryBuilder Self => this;

        public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder() : this("customerEmailMarketingConsentUpdatePayload")
        {
        }

        public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder(string name) : base(new Query<CustomerEmailMarketingConsentUpdatePayload>(name))
        {
        }

        public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder(IQuery<CustomerEmailMarketingConsentUpdatePayload> query) : base(query)
        {
        }

        public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerEmailMarketingConsentUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerEmailMarketingConsentUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailMarketingConsentUpdateUserError>(query);
            return this;
        }
    }
}