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
    public sealed class PurchasingEntityAddressesQueryBuilder : FieldsQueryBuilderBase<MailingAddress, PurchasingEntityAddressesQueryBuilder>, IHasArguments<PurchasingEntityAddressesArgumentsBuilder>
    {
        public PurchasingEntityAddressesArgumentsBuilder Arguments { get; }
        protected override PurchasingEntityAddressesQueryBuilder Self => this;

        public PurchasingEntityAddressesQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
            Arguments = new PurchasingEntityAddressesArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntityAddressesQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
            Arguments = new PurchasingEntityAddressesArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntityAddressesQueryBuilder SetArguments(Action<PurchasingEntityAddressesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public PurchasingEntityAddressesQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public PurchasingEntityAddressesQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}