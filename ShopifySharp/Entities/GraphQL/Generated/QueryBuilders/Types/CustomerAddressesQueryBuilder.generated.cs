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
    public sealed class CustomerAddressesQueryBuilder : FieldsQueryBuilderBase<MailingAddress, CustomerAddressesQueryBuilder>, IHasArguments<CustomerAddressesArgumentsBuilder>
    {
        public CustomerAddressesArgumentsBuilder Arguments { get; }
        protected override CustomerAddressesQueryBuilder Self => this;

        public CustomerAddressesQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
            Arguments = new CustomerAddressesArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressesQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
            Arguments = new CustomerAddressesArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressesQueryBuilder SetArguments(Action<CustomerAddressesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerAddressesQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public CustomerAddressesQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public CustomerAddressesQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public CustomerAddressesQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public CustomerAddressesQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public CustomerAddressesQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public CustomerAddressesQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CustomerAddressesQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public CustomerAddressesQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CustomerAddressesQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public CustomerAddressesQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public CustomerAddressesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CustomerAddressesQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CustomerAddressesQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public CustomerAddressesQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public CustomerAddressesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CustomerAddressesQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CustomerAddressesQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public CustomerAddressesQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public CustomerAddressesQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public CustomerAddressesQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public CustomerAddressesQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}