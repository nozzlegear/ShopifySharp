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
    public sealed class LocationAddressQueryBuilder : FieldsQueryBuilderBase<LocationAddress, LocationAddressQueryBuilder>
    {
        protected override LocationAddressQueryBuilder Self => this;

        public LocationAddressQueryBuilder() : this("locationAddress")
        {
        }

        public LocationAddressQueryBuilder(string name) : base(new Query<LocationAddress>(name))
        {
        }

        public LocationAddressQueryBuilder(IQuery<LocationAddress> query) : base(query)
        {
        }

        public LocationAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public LocationAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public LocationAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public LocationAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public LocationAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public LocationAddressQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public LocationAddressQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public LocationAddressQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public LocationAddressQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public LocationAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public LocationAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public LocationAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}