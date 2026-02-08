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
    public sealed class FulfillmentOriginAddressQueryBuilder : FieldsQueryBuilderBase<FulfillmentOriginAddress, FulfillmentOriginAddressQueryBuilder>
    {
        protected override FulfillmentOriginAddressQueryBuilder Self => this;

        public FulfillmentOriginAddressQueryBuilder() : this("fulfillmentOriginAddress")
        {
        }

        public FulfillmentOriginAddressQueryBuilder(string name) : base(new Query<FulfillmentOriginAddress>(name))
        {
        }

        public FulfillmentOriginAddressQueryBuilder(IQuery<FulfillmentOriginAddress> query) : base(query)
        {
        }

        public FulfillmentOriginAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public FulfillmentOriginAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public FulfillmentOriginAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public FulfillmentOriginAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public FulfillmentOriginAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public FulfillmentOriginAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}