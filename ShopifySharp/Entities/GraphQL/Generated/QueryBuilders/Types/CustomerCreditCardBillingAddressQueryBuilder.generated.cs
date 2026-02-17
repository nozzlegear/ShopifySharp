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
    public sealed class CustomerCreditCardBillingAddressQueryBuilder : FieldsQueryBuilderBase<CustomerCreditCardBillingAddress, CustomerCreditCardBillingAddressQueryBuilder>
    {
        protected override CustomerCreditCardBillingAddressQueryBuilder Self => this;

        public CustomerCreditCardBillingAddressQueryBuilder() : this("customerCreditCardBillingAddress")
        {
        }

        public CustomerCreditCardBillingAddressQueryBuilder(string name) : base(new Query<CustomerCreditCardBillingAddress>(name))
        {
        }

        public CustomerCreditCardBillingAddressQueryBuilder(IQuery<CustomerCreditCardBillingAddress> query) : base(query)
        {
        }

        public CustomerCreditCardBillingAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public CustomerCreditCardBillingAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}