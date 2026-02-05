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
    public sealed class CustomerPaymentInstrumentBillingAddressQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentInstrumentBillingAddress, CustomerPaymentInstrumentBillingAddressQueryBuilder>
    {
        protected override CustomerPaymentInstrumentBillingAddressQueryBuilder Self => this;

        public CustomerPaymentInstrumentBillingAddressQueryBuilder() : this("customerPaymentInstrumentBillingAddress")
        {
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder(string name) : base(new Query<CustomerPaymentInstrumentBillingAddress>(name))
        {
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder(IQuery<CustomerPaymentInstrumentBillingAddress> query) : base(query)
        {
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public CustomerPaymentInstrumentBillingAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}