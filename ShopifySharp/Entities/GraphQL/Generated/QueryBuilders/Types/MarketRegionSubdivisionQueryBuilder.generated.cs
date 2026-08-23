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
    public sealed class MarketRegionSubdivisionQueryBuilder : FieldsQueryBuilderBase<MarketRegionSubdivision, MarketRegionSubdivisionQueryBuilder>
    {
        protected override MarketRegionSubdivisionQueryBuilder Self => this;

        public MarketRegionSubdivisionQueryBuilder() : this("marketRegionSubdivision")
        {
        }

        public MarketRegionSubdivisionQueryBuilder(string name) : base(new Query<MarketRegionSubdivision>(name))
        {
        }

        public MarketRegionSubdivisionQueryBuilder(IQuery<MarketRegionSubdivision> query) : base(query)
        {
        }

        public MarketRegionSubdivisionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketRegionSubdivisionQueryBuilder Country(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivisionCountry>("country");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionSubdivisionCountry>(query);
            return this;
        }

        public MarketRegionSubdivisionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketRegionSubdivisionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}