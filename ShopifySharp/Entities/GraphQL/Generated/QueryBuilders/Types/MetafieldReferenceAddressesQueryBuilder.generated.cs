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
    public sealed class MetafieldReferenceAddressesQueryBuilder : FieldsQueryBuilderBase<MailingAddress, MetafieldReferenceAddressesQueryBuilder>, IHasArguments<MetafieldReferenceAddressesArgumentsBuilder>
    {
        public MetafieldReferenceAddressesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceAddressesQueryBuilder Self => this;

        public MetafieldReferenceAddressesQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
            Arguments = new MetafieldReferenceAddressesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAddressesQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
            Arguments = new MetafieldReferenceAddressesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAddressesQueryBuilder SetArguments(Action<MetafieldReferenceAddressesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public MetafieldReferenceAddressesQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public MetafieldReferenceAddressesQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}