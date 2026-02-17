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
    public sealed class LocationSuggestedAddressQueryBuilder : FieldsQueryBuilderBase<LocationSuggestedAddress, LocationSuggestedAddressQueryBuilder>
    {
        protected override LocationSuggestedAddressQueryBuilder Self => this;

        public LocationSuggestedAddressQueryBuilder() : this("locationSuggestedAddress")
        {
        }

        public LocationSuggestedAddressQueryBuilder(string name) : base(new Query<LocationSuggestedAddress>(name))
        {
        }

        public LocationSuggestedAddressQueryBuilder(IQuery<LocationSuggestedAddress> query) : base(query)
        {
        }

        public LocationSuggestedAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public LocationSuggestedAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}