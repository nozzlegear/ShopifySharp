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
    public sealed class MetafieldReferencerAddressesQueryBuilder : FieldsQueryBuilderBase<MailingAddress, MetafieldReferencerAddressesQueryBuilder>, IHasArguments<MetafieldReferencerAddressesArgumentsBuilder>
    {
        public MetafieldReferencerAddressesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerAddressesQueryBuilder Self => this;

        public MetafieldReferencerAddressesQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
            Arguments = new MetafieldReferencerAddressesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerAddressesQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
            Arguments = new MetafieldReferencerAddressesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerAddressesQueryBuilder SetArguments(Action<MetafieldReferencerAddressesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public MetafieldReferencerAddressesQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public MetafieldReferencerAddressesQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}