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
    public sealed class CustomerSmsMarketingConsentErrorQueryBuilder : FieldsQueryBuilderBase<CustomerSmsMarketingConsentError, CustomerSmsMarketingConsentErrorQueryBuilder>
    {
        protected override CustomerSmsMarketingConsentErrorQueryBuilder Self => this;

        public CustomerSmsMarketingConsentErrorQueryBuilder() : this("customerSmsMarketingConsentError")
        {
        }

        public CustomerSmsMarketingConsentErrorQueryBuilder(string name) : base(new Query<CustomerSmsMarketingConsentError>(name))
        {
        }

        public CustomerSmsMarketingConsentErrorQueryBuilder(IQuery<CustomerSmsMarketingConsentError> query) : base(query)
        {
        }

        public CustomerSmsMarketingConsentErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerSmsMarketingConsentErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerSmsMarketingConsentErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}