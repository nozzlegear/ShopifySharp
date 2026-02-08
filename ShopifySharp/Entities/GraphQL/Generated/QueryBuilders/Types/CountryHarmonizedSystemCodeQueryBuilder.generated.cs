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
    public sealed class CountryHarmonizedSystemCodeQueryBuilder : FieldsQueryBuilderBase<CountryHarmonizedSystemCode, CountryHarmonizedSystemCodeQueryBuilder>
    {
        protected override CountryHarmonizedSystemCodeQueryBuilder Self => this;

        public CountryHarmonizedSystemCodeQueryBuilder() : this("countryHarmonizedSystemCode")
        {
        }

        public CountryHarmonizedSystemCodeQueryBuilder(string name) : base(new Query<CountryHarmonizedSystemCode>(name))
        {
        }

        public CountryHarmonizedSystemCodeQueryBuilder(IQuery<CountryHarmonizedSystemCode> query) : base(query)
        {
        }

        public CountryHarmonizedSystemCodeQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public CountryHarmonizedSystemCodeQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }
    }
}