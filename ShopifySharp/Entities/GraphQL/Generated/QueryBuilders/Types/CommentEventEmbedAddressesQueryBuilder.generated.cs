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
    public sealed class CommentEventEmbedAddressesQueryBuilder : FieldsQueryBuilderBase<MailingAddress, CommentEventEmbedAddressesQueryBuilder>, IHasArguments<CommentEventEmbedAddressesArgumentsBuilder>
    {
        public CommentEventEmbedAddressesArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedAddressesQueryBuilder Self => this;

        public CommentEventEmbedAddressesQueryBuilder(string name) : base(new Query<MailingAddress>(name))
        {
            Arguments = new CommentEventEmbedAddressesArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedAddressesQueryBuilder(IQuery<MailingAddress> query) : base(query)
        {
            Arguments = new CommentEventEmbedAddressesArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedAddressesQueryBuilder SetArguments(Action<CommentEventEmbedAddressesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder CoordinatesValidated()
        {
            base.InnerQuery.AddField("coordinatesValidated");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        [Obsolete("Use `countryCodeV2` instead.")]
        public CommentEventEmbedAddressesQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder CountryCodeV2()
        {
            base.InnerQuery.AddField("countryCodeV2");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Formatted()
        {
            base.InnerQuery.AddField("formatted");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder ProvinceCode()
        {
            base.InnerQuery.AddField("provinceCode");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder ValidationResultSummary()
        {
            base.InnerQuery.AddField("validationResultSummary");
            return this;
        }

        public CommentEventEmbedAddressesQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}