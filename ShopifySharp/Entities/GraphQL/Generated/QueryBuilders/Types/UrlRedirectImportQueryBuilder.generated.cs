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
    public sealed class UrlRedirectImportQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImport, UrlRedirectImportQueryBuilder>
    {
        protected override UrlRedirectImportQueryBuilder Self => this;

        public UrlRedirectImportQueryBuilder() : this("urlRedirectImport")
        {
        }

        public UrlRedirectImportQueryBuilder(string name) : base(new Query<UrlRedirectImport>(name))
        {
        }

        public UrlRedirectImportQueryBuilder(IQuery<UrlRedirectImport> query) : base(query)
        {
        }

        public UrlRedirectImportQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public UrlRedirectImportQueryBuilder CreatedCount()
        {
            base.InnerQuery.AddField("createdCount");
            return this;
        }

        public UrlRedirectImportQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public UrlRedirectImportQueryBuilder Finished()
        {
            base.InnerQuery.AddField("finished");
            return this;
        }

        public UrlRedirectImportQueryBuilder FinishedAt()
        {
            base.InnerQuery.AddField("finishedAt");
            return this;
        }

        public UrlRedirectImportQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UrlRedirectImportQueryBuilder PreviewRedirects(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportPreview>("previewRedirects");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportPreview>(query);
            return this;
        }

        public UrlRedirectImportQueryBuilder UpdatedCount()
        {
            base.InnerQuery.AddField("updatedCount");
            return this;
        }
    }
}