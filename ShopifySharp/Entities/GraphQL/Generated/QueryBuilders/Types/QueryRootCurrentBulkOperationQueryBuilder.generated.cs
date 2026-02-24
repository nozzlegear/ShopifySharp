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
    public sealed class QueryRootCurrentBulkOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperation, QueryRootCurrentBulkOperationQueryBuilder>, IHasArguments<QueryRootCurrentBulkOperationArgumentsBuilder>
    {
        public QueryRootCurrentBulkOperationArgumentsBuilder Arguments { get; }
        protected override QueryRootCurrentBulkOperationQueryBuilder Self => this;

        public QueryRootCurrentBulkOperationQueryBuilder(string name) : base(new Query<BulkOperation>(name))
        {
            Arguments = new QueryRootCurrentBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCurrentBulkOperationQueryBuilder(IQuery<BulkOperation> query) : base(query)
        {
            Arguments = new QueryRootCurrentBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCurrentBulkOperationQueryBuilder SetArguments(Action<QueryRootCurrentBulkOperationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder ObjectCount()
        {
            base.InnerQuery.AddField("objectCount");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder PartialDataUrl()
        {
            base.InnerQuery.AddField("partialDataUrl");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder RootObjectCount()
        {
            base.InnerQuery.AddField("rootObjectCount");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public QueryRootCurrentBulkOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}