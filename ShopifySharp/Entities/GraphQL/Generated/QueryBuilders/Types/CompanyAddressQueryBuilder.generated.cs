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
    public sealed class CompanyAddressQueryBuilder : FieldsQueryBuilderBase<CompanyAddress, CompanyAddressQueryBuilder>
    {
        protected override CompanyAddressQueryBuilder Self => this;

        public CompanyAddressQueryBuilder() : this("companyAddress")
        {
        }

        public CompanyAddressQueryBuilder(string name) : base(new Query<CompanyAddress>(name))
        {
        }

        public CompanyAddressQueryBuilder(IQuery<CompanyAddress> query) : base(query)
        {
        }

        public CompanyAddressQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public CompanyAddressQueryBuilder Address2()
        {
            base.InnerQuery.AddField("address2");
            return this;
        }

        public CompanyAddressQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public CompanyAddressQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public CompanyAddressQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public CompanyAddressQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CompanyAddressQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyAddressQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CompanyAddressQueryBuilder FormattedAddress()
        {
            base.InnerQuery.AddField("formattedAddress");
            return this;
        }

        public CompanyAddressQueryBuilder FormattedArea()
        {
            base.InnerQuery.AddField("formattedArea");
            return this;
        }

        public CompanyAddressQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyAddressQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CompanyAddressQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CompanyAddressQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public CompanyAddressQueryBuilder Recipient()
        {
            base.InnerQuery.AddField("recipient");
            return this;
        }

        public CompanyAddressQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CompanyAddressQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }

        public CompanyAddressQueryBuilder ZoneCode()
        {
            base.InnerQuery.AddField("zoneCode");
            return this;
        }
    }
}