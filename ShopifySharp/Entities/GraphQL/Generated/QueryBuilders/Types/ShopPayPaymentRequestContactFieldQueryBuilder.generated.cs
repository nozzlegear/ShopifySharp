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
    public sealed class ShopPayPaymentRequestContactFieldQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestContactField, ShopPayPaymentRequestContactFieldQueryBuilder>
    {
        protected override ShopPayPaymentRequestContactFieldQueryBuilder Self => this;

        public ShopPayPaymentRequestContactFieldQueryBuilder() : this("shopPayPaymentRequestContactField")
        {
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestContactField>(name))
        {
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder(IQuery<ShopPayPaymentRequestContactField> query) : base(query)
        {
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder PostalCode()
        {
            base.InnerQuery.AddField("postalCode");
            return this;
        }

        public ShopPayPaymentRequestContactFieldQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }
    }
}