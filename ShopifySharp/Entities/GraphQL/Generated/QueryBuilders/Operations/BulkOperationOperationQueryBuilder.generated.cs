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
    public sealed class BulkOperationOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperation, BulkOperationOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public BulkOperationArgumentsBuilder Arguments { get; }
        protected override BulkOperationOperationQueryBuilder Self => this;

        public BulkOperationOperationQueryBuilder() : this("bulkOperation")
        {
        }

        public BulkOperationOperationQueryBuilder(string name) : base(new Query<BulkOperation>(name))
        {
            Arguments = new BulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationOperationQueryBuilder(IQuery<BulkOperation> query) : base(query)
        {
            Arguments = new BulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public BulkOperationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public BulkOperationOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public BulkOperationOperationQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public BulkOperationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BulkOperationOperationQueryBuilder ObjectCount()
        {
            base.InnerQuery.AddField("objectCount");
            return this;
        }

        public BulkOperationOperationQueryBuilder PartialDataUrl()
        {
            base.InnerQuery.AddField("partialDataUrl");
            return this;
        }

        public BulkOperationOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public BulkOperationOperationQueryBuilder RootObjectCount()
        {
            base.InnerQuery.AddField("rootObjectCount");
            return this;
        }

        public BulkOperationOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public BulkOperationOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public BulkOperationOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}