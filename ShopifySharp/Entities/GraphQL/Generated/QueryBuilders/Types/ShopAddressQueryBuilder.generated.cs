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
    public sealed class ShopAddressQueryBuilder : FieldsQueryBuilderBase<ShopAddress, ShopAddressQueryBuilder>
    {
        protected override ShopAddressQueryBuilder Self => this;

        public ShopAddressQueryBuilder() : this("shopAddress")
        {
        }

        public ShopAddressQueryBuilder(string name) : base(new Query<ShopAddress>(name))
        {
        }

        public ShopAddressQueryBuilder(IQuery<ShopAddress> query) : base(query)
        {
        }

        public ShopAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public ShopAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public ShopAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public ShopAddressQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public ShopAddressQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public ShopAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public ShopAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public ShopAddressQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        [Obsolete("Always null in this context.")]
        public ShopAddressQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public ShopAddressQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public ShopAddressQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public ShopAddressQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Always null in this context.")]
        public ShopAddressQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public ShopAddressQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public ShopAddressQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        [Obsolete("Always null in this context.")]
        public ShopAddressQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopAddressQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public ShopAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public ShopAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public ShopAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}