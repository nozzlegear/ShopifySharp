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
    public sealed class QueryRootBulkOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperation, QueryRootBulkOperationQueryBuilder>, IHasArguments<QueryRootBulkOperationArgumentsBuilder>
    {
        public QueryRootBulkOperationArgumentsBuilder Arguments { get; }
        protected override QueryRootBulkOperationQueryBuilder Self => this;

        public QueryRootBulkOperationQueryBuilder(string name) : base(new Query<BulkOperation>(name))
        {
            Arguments = new QueryRootBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBulkOperationQueryBuilder(IQuery<BulkOperation> query) : base(query)
        {
            Arguments = new QueryRootBulkOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBulkOperationQueryBuilder SetArguments(Action<QueryRootBulkOperationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootBulkOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder ObjectCount()
        {
            base.InnerQuery.AddField("objectCount");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder PartialDataUrl()
        {
            base.InnerQuery.AddField("partialDataUrl");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder RootObjectCount()
        {
            base.InnerQuery.AddField("rootObjectCount");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public QueryRootBulkOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}