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
    public sealed class BackupRegionOperationQueryBuilder : FieldsQueryBuilderBase<IMarketRegion, BackupRegionOperationQueryBuilder>, IGraphOperationQueryBuilder<IMarketRegion>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override BackupRegionOperationQueryBuilder Self => this;

        public BackupRegionOperationQueryBuilder() : this("backupRegion")
        {
        }

        public BackupRegionOperationQueryBuilder(string name) : base(new Query<IMarketRegion>(name))
        {
        }

        public BackupRegionOperationQueryBuilder(IQuery<IMarketRegion> query) : base(query)
        {
        }

        public BackupRegionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BackupRegionOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public BackupRegionOperationQueryBuilder OnMarketRegionCountry(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder> build)
        {
            var query = new Query<MarketRegionCountry>("... on MarketRegionCountry");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public BackupRegionOperationQueryBuilder OnMarketRegionSubdivision(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder> build)
        {
            var query = new Query<MarketRegionSubdivision>("... on MarketRegionSubdivision");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionSubdivisionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}