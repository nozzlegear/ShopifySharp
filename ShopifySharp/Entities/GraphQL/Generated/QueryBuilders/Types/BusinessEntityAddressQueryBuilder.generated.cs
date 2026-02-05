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
    public sealed class BusinessEntityAddressQueryBuilder : FieldsQueryBuilderBase<BusinessEntityAddress, BusinessEntityAddressQueryBuilder>
    {
        protected override BusinessEntityAddressQueryBuilder Self => this;

        public BusinessEntityAddressQueryBuilder() : this("businessEntityAddress")
        {
        }

        public BusinessEntityAddressQueryBuilder(string name) : base(new Query<BusinessEntityAddress>(name))
        {
        }

        public BusinessEntityAddressQueryBuilder(IQuery<BusinessEntityAddress> query) : base(query)
        {
        }

        public BusinessEntityAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public BusinessEntityAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public BusinessEntityAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public BusinessEntityAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public BusinessEntityAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public BusinessEntityAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}