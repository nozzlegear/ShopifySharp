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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AvailableBackupRegionsOperationQueryBuilder : FieldsQueryBuilderBase<IMarketRegion, AvailableBackupRegionsOperationQueryBuilder>, IGraphOperationQueryBuilder<IMarketRegion>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override AvailableBackupRegionsOperationQueryBuilder Self => this;

        public AvailableBackupRegionsOperationQueryBuilder() : this("availableBackupRegions")
        {
        }

        public AvailableBackupRegionsOperationQueryBuilder(string name) : base(new Query<IMarketRegion>(name))
        {
        }

        public AvailableBackupRegionsOperationQueryBuilder(IQuery<IMarketRegion> query) : base(query)
        {
        }

        public AvailableBackupRegionsOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AvailableBackupRegionsOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AvailableBackupRegionsOperationQueryBuilder OnMarketRegionCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionCountry>("... on MarketRegionCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public AvailableBackupRegionsOperationQueryBuilder OnMarketRegionSubdivision(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivision>("... on MarketRegionSubdivision");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}