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
    public sealed class FullSyncTraceInfoQueryBuilder : FieldsQueryBuilderBase<FullSyncTraceInfo, FullSyncTraceInfoQueryBuilder>
    {
        protected override FullSyncTraceInfoQueryBuilder Self => this;

        public FullSyncTraceInfoQueryBuilder() : this("fullSyncTraceInfo")
        {
        }

        public FullSyncTraceInfoQueryBuilder(string name) : base(new Query<FullSyncTraceInfo>(name))
        {
        }

        public FullSyncTraceInfoQueryBuilder(IQuery<FullSyncTraceInfo> query) : base(query)
        {
        }

        public FullSyncTraceInfoQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public FullSyncTraceInfoQueryBuilder Language()
        {
            base.InnerQuery.AddField("language");
            return this;
        }

        public FullSyncTraceInfoQueryBuilder OperationId()
        {
            base.InnerQuery.AddField("operationId");
            return this;
        }
    }
}