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
    public sealed class CustomerMarketingConsentErrorQueryBuilder : FieldsQueryBuilderBase<CustomerMarketingConsentError, CustomerMarketingConsentErrorQueryBuilder>
    {
        protected override CustomerMarketingConsentErrorQueryBuilder Self => this;

        public CustomerMarketingConsentErrorQueryBuilder() : this("customerMarketingConsentError")
        {
        }

        public CustomerMarketingConsentErrorQueryBuilder(string name) : base(new Query<CustomerMarketingConsentError>(name))
        {
        }

        public CustomerMarketingConsentErrorQueryBuilder(IQuery<CustomerMarketingConsentError> query) : base(query)
        {
        }

        public CustomerMarketingConsentErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerMarketingConsentErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerMarketingConsentErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}