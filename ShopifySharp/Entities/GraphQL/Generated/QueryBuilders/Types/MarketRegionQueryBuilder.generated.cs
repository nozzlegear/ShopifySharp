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
    public sealed class MarketRegionQueryBuilder : FieldsQueryBuilderBase<IMarketRegion, MarketRegionQueryBuilder>
    {
        protected override MarketRegionQueryBuilder Self => this;

        public MarketRegionQueryBuilder() : this("marketRegion")
        {
        }

        public MarketRegionQueryBuilder(string name) : base(new Query<IMarketRegion>(name))
        {
        }

        public MarketRegionQueryBuilder(IQuery<IMarketRegion> query) : base(query)
        {
        }

        public MarketRegionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketRegionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MarketRegionQueryBuilder OnMarketRegionCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionCountry>("... on MarketRegionCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MarketRegionQueryBuilder OnMarketRegionSubdivision(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivision>("... on MarketRegionSubdivision");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public MarketRegionQueryBuilder MarketRegion(Action<MarketRegionInterfaceCasesBuilder> build)
        {
            var query = new Query<IMarketRegion>("marketRegion");
            var unionBuilder = new MarketRegionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}