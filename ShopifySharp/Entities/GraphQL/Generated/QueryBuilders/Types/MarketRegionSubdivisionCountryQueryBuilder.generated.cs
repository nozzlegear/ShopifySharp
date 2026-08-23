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
    public sealed class MarketRegionSubdivisionCountryQueryBuilder : FieldsQueryBuilderBase<MarketRegionSubdivisionCountry, MarketRegionSubdivisionCountryQueryBuilder>
    {
        protected override MarketRegionSubdivisionCountryQueryBuilder Self => this;

        public MarketRegionSubdivisionCountryQueryBuilder() : this("marketRegionSubdivisionCountry")
        {
        }

        public MarketRegionSubdivisionCountryQueryBuilder(string name) : base(new Query<MarketRegionSubdivisionCountry>(name))
        {
        }

        public MarketRegionSubdivisionCountryQueryBuilder(IQuery<MarketRegionSubdivisionCountry> query) : base(query)
        {
        }

        public MarketRegionSubdivisionCountryQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketRegionSubdivisionCountryQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}