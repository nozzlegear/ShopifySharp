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
    [Obsolete("Use `bulkOperations` with status filter instead.")]
    public sealed class CurrentBulkOperationOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperation, CurrentBulkOperationOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CurrentBulkOperationArgumentsBuilder Arguments { get; }
        protected override CurrentBulkOperationOperationQueryBuilder Self => this;

        public CurrentBulkOperationOperationQueryBuilder() : this("currentBulkOperation")
        {
        }

        public CurrentBulkOperationOperationQueryBuilder(string name) : base(new Query<BulkOperation>(name))
        {
            Arguments = new CurrentBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public CurrentBulkOperationOperationQueryBuilder(IQuery<BulkOperation> query) : base(query)
        {
            Arguments = new CurrentBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public CurrentBulkOperationOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder ObjectCount()
        {
            base.InnerQuery.AddField("objectCount");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder PartialDataUrl()
        {
            base.InnerQuery.AddField("partialDataUrl");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder RootObjectCount()
        {
            base.InnerQuery.AddField("rootObjectCount");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public CurrentBulkOperationOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}