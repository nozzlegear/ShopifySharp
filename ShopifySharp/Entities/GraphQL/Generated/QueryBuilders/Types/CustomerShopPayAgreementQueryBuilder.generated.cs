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
    public sealed class CustomerShopPayAgreementQueryBuilder : FieldsQueryBuilderBase<CustomerShopPayAgreement, CustomerShopPayAgreementQueryBuilder>
    {
        protected override CustomerShopPayAgreementQueryBuilder Self => this;

        public CustomerShopPayAgreementQueryBuilder() : this("customerShopPayAgreement")
        {
        }

        public CustomerShopPayAgreementQueryBuilder(string name) : base(new Query<CustomerShopPayAgreement>(name))
        {
        }

        public CustomerShopPayAgreementQueryBuilder(IQuery<CustomerShopPayAgreement> query) : base(query)
        {
        }

        public CustomerShopPayAgreementQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder> build)
        {
            var query = new Query<CustomerCreditCardBillingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerCreditCardBillingAddress>(query);
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder ExpiresSoon()
        {
            base.InnerQuery.AddField("expiresSoon");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder ExpiryMonth()
        {
            base.InnerQuery.AddField("expiryMonth");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder ExpiryYear()
        {
            base.InnerQuery.AddField("expiryYear");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder Inactive()
        {
            base.InnerQuery.AddField("inactive");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder IsRevocable()
        {
            base.InnerQuery.AddField("isRevocable");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder LastDigits()
        {
            base.InnerQuery.AddField("lastDigits");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder MaskedNumber()
        {
            base.InnerQuery.AddField("maskedNumber");
            return this;
        }

        public CustomerShopPayAgreementQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}