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
    public sealed class BackupRegionUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<BackupRegionUpdatePayload, BackupRegionUpdatePayloadQueryBuilder>
    {
        protected override BackupRegionUpdatePayloadQueryBuilder Self => this;

        public BackupRegionUpdatePayloadQueryBuilder() : this("backupRegionUpdatePayload")
        {
        }

        public BackupRegionUpdatePayloadQueryBuilder(string name) : base(new Query<BackupRegionUpdatePayload>(name))
        {
        }

        public BackupRegionUpdatePayloadQueryBuilder(IQuery<BackupRegionUpdatePayload> query) : base(query)
        {
        }

        public BackupRegionUpdatePayloadQueryBuilder BackupRegion(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("backupRegion");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public BackupRegionUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}