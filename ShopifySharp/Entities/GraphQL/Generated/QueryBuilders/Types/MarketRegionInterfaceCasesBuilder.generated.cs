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
    public sealed class MarketRegionInterfaceCasesBuilder : InterfaceCasesBuilderBase<IMarketRegion, MarketRegionInterfaceCasesBuilder>
    {
        protected override MarketRegionInterfaceCasesBuilder Self => this;

        public MarketRegionInterfaceCasesBuilder(string fieldName = "backupRegion") : this(new Query<IMarketRegion>(fieldName))
        {
        }

        public MarketRegionInterfaceCasesBuilder(IQuery<IMarketRegion> query) : base(query)
        {
        }

        public MarketRegionInterfaceCasesBuilder OnMarketRegionCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionCountry>("... on MarketRegionCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MarketRegionInterfaceCasesBuilder OnMarketRegionSubdivision(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivision>("... on MarketRegionSubdivision");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}