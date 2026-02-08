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
    public sealed class BulkOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperation, BulkOperationQueryBuilder>
    {
        protected override BulkOperationQueryBuilder Self => this;

        public BulkOperationQueryBuilder() : this("bulkOperation")
        {
        }

        public BulkOperationQueryBuilder(string name) : base(new Query<BulkOperation>(name))
        {
        }

        public BulkOperationQueryBuilder(IQuery<BulkOperation> query) : base(query)
        {
        }

        public BulkOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public BulkOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public BulkOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public BulkOperationQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public BulkOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BulkOperationQueryBuilder ObjectCount()
        {
            base.InnerQuery.AddField("objectCount");
            return this;
        }

        public BulkOperationQueryBuilder PartialDataUrl()
        {
            base.InnerQuery.AddField("partialDataUrl");
            return this;
        }

        public BulkOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public BulkOperationQueryBuilder RootObjectCount()
        {
            base.InnerQuery.AddField("rootObjectCount");
            return this;
        }

        public BulkOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public BulkOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public BulkOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}