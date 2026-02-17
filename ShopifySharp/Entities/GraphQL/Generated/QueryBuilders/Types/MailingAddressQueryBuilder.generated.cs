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
    public sealed class MailingAddressQueryBuilder : FieldsQueryBuilderBase<MailingAddress, MailingAddressQueryBuilder>
    {
        protected override MailingAddressQueryBuilder Self => this;

        public MailingAddressQueryBuilder() : this("mailingAddress")
        {
        }

        public MailingAddressQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
        }

        public MailingAddressQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
        }

        public MailingAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public MailingAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public MailingAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public MailingAddressQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public MailingAddressQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public MailingAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public MailingAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public MailingAddressQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public MailingAddressQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public MailingAddressQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public MailingAddressQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public MailingAddressQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MailingAddressQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public MailingAddressQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public MailingAddressQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public MailingAddressQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MailingAddressQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public MailingAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public MailingAddressQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public MailingAddressQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public MailingAddressQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public MailingAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}