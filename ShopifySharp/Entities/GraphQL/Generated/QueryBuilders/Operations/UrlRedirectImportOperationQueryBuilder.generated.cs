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
    public sealed class UrlRedirectImportOperationQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImport, UrlRedirectImportOperationQueryBuilder>, IGraphOperationQueryBuilder<UrlRedirectImport>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public UrlRedirectImportArgumentsBuilder Arguments { get; }
        protected override UrlRedirectImportOperationQueryBuilder Self => this;

        public UrlRedirectImportOperationQueryBuilder() : this("urlRedirectImport")
        {
        }

        public UrlRedirectImportOperationQueryBuilder(string name) : base(new Query<UrlRedirectImport>(name))
        {
            Arguments = new UrlRedirectImportArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportOperationQueryBuilder(IQuery<UrlRedirectImport> query) : base(query)
        {
            Arguments = new UrlRedirectImportArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectImportOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder CreatedCount()
        {
            base.InnerQuery.AddField("createdCount");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder Finished()
        {
            base.InnerQuery.AddField("finished");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder FinishedAt()
        {
            base.InnerQuery.AddField("finishedAt");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder PreviewRedirects(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportPreview>("previewRedirects");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportPreview>(query);
            return this;
        }

        public UrlRedirectImportOperationQueryBuilder UpdatedCount()
        {
            base.InnerQuery.AddField("updatedCount");
            return this;
        }
    }
}