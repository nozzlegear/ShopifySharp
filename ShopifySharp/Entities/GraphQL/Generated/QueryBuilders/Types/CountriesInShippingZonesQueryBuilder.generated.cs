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
    public sealed class CountriesInShippingZonesQueryBuilder : FieldsQueryBuilderBase<CountriesInShippingZones, CountriesInShippingZonesQueryBuilder>
    {
        protected override CountriesInShippingZonesQueryBuilder Self => this;

        public CountriesInShippingZonesQueryBuilder() : this("countriesInShippingZones")
        {
        }

        public CountriesInShippingZonesQueryBuilder(string name) : base(new Query<CountriesInShippingZones>(name))
        {
        }

        public CountriesInShippingZonesQueryBuilder(IQuery<CountriesInShippingZones> query) : base(query)
        {
        }

        public CountriesInShippingZonesQueryBuilder CountryCodes()
        {
            base.InnerQuery.AddField("countryCodes");
            return this;
        }

        public CountriesInShippingZonesQueryBuilder IncludeRestOfWorld()
        {
            base.InnerQuery.AddField("includeRestOfWorld");
            return this;
        }
    }
}