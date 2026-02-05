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
    public sealed class CustomerCreditCardQueryBuilder : FieldsQueryBuilderBase<CustomerCreditCard, CustomerCreditCardQueryBuilder>
    {
        protected override CustomerCreditCardQueryBuilder Self => this;

        public CustomerCreditCardQueryBuilder() : this("customerCreditCard")
        {
        }

        public CustomerCreditCardQueryBuilder(string name) : base(new Query<CustomerCreditCard>(name))
        {
        }

        public CustomerCreditCardQueryBuilder(IQuery<CustomerCreditCard> query) : base(query)
        {
        }

        public CustomerCreditCardQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder> build)
        {
            var query = new Query<CustomerCreditCardBillingAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerCreditCardBillingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerCreditCardBillingAddress>(query);
            return this;
        }

        public CustomerCreditCardQueryBuilder Brand()
        {
            base.InnerQuery.AddField("brand");
            return this;
        }

        public CustomerCreditCardQueryBuilder ExpiresSoon()
        {
            base.InnerQuery.AddField("expiresSoon");
            return this;
        }

        public CustomerCreditCardQueryBuilder ExpiryMonth()
        {
            base.InnerQuery.AddField("expiryMonth");
            return this;
        }

        public CustomerCreditCardQueryBuilder ExpiryYear()
        {
            base.InnerQuery.AddField("expiryYear");
            return this;
        }

        public CustomerCreditCardQueryBuilder FirstDigits()
        {
            base.InnerQuery.AddField("firstDigits");
            return this;
        }

        public CustomerCreditCardQueryBuilder IsRevocable()
        {
            base.InnerQuery.AddField("isRevocable");
            return this;
        }

        public CustomerCreditCardQueryBuilder LastDigits()
        {
            base.InnerQuery.AddField("lastDigits");
            return this;
        }

        public CustomerCreditCardQueryBuilder MaskedNumber()
        {
            base.InnerQuery.AddField("maskedNumber");
            return this;
        }

        public CustomerCreditCardQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CustomerCreditCardQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public CustomerCreditCardQueryBuilder VirtualLastDigits()
        {
            base.InnerQuery.AddField("virtualLastDigits");
            return this;
        }
    }
}