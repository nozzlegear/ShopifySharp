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
    public sealed class CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerEmailMarketingConsentUpdateUserError, CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder>
    {
        protected override CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder Self => this;

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder() : this("customerEmailMarketingConsentUpdateUserError")
        {
        }

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder(string name) : base(new Query<CustomerEmailMarketingConsentUpdateUserError>(name))
        {
        }

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder(IQuery<CustomerEmailMarketingConsentUpdateUserError> query) : base(query)
        {
        }

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}