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
    public sealed class BackupRegionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<BackupRegionUpdatePayload, BackupRegionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<BackupRegionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BackupRegionUpdateArgumentsBuilder Arguments { get; }
        protected override BackupRegionUpdateOperationQueryBuilder Self => this;

        public BackupRegionUpdateOperationQueryBuilder() : this("backupRegionUpdate")
        {
        }

        public BackupRegionUpdateOperationQueryBuilder(string name) : base(new Query<BackupRegionUpdatePayload>(name))
        {
            Arguments = new BackupRegionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public BackupRegionUpdateOperationQueryBuilder(IQuery<BackupRegionUpdatePayload> query) : base(query)
        {
            Arguments = new BackupRegionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public BackupRegionUpdateOperationQueryBuilder BackupRegion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("backupRegion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public BackupRegionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}