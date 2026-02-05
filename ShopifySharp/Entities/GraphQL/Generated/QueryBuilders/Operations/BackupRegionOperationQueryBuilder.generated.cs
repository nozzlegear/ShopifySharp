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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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
    }
}