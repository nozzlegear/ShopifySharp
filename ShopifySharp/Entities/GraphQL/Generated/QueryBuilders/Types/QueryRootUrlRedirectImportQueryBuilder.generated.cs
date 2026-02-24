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
    public sealed class QueryRootUrlRedirectImportQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImport, QueryRootUrlRedirectImportQueryBuilder>, IHasArguments<QueryRootUrlRedirectImportArgumentsBuilder>
    {
        public QueryRootUrlRedirectImportArgumentsBuilder Arguments { get; }
        protected override QueryRootUrlRedirectImportQueryBuilder Self => this;

        public QueryRootUrlRedirectImportQueryBuilder(string name) : base(new Query<UrlRedirectImport>(name))
        {
            Arguments = new QueryRootUrlRedirectImportArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectImportQueryBuilder(IQuery<UrlRedirectImport> query) : base(query)
        {
            Arguments = new QueryRootUrlRedirectImportArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectImportQueryBuilder SetArguments(Action<QueryRootUrlRedirectImportArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder CreatedCount()
        {
            base.InnerQuery.AddField("createdCount");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder Finished()
        {
            base.InnerQuery.AddField("finished");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder FinishedAt()
        {
            base.InnerQuery.AddField("finishedAt");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder PreviewRedirects(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportPreview>("previewRedirects");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UrlRedirectImportPreviewQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportPreview>(query);
            return this;
        }

        public QueryRootUrlRedirectImportQueryBuilder UpdatedCount()
        {
            base.InnerQuery.AddField("updatedCount");
            return this;
        }
    }
}