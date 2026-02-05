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
    public sealed class UrlRedirectImportPreviewQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportPreview, UrlRedirectImportPreviewQueryBuilder>
    {
        protected override UrlRedirectImportPreviewQueryBuilder Self => this;

        public UrlRedirectImportPreviewQueryBuilder() : this("urlRedirectImportPreview")
        {
        }

        public UrlRedirectImportPreviewQueryBuilder(string name) : base(new Query<UrlRedirectImportPreview>(name))
        {
        }

        public UrlRedirectImportPreviewQueryBuilder(IQuery<UrlRedirectImportPreview> query) : base(query)
        {
        }

        public UrlRedirectImportPreviewQueryBuilder Path()
        {
            base.InnerQuery.AddField("path");
            return this;
        }

        public UrlRedirectImportPreviewQueryBuilder Target()
        {
            base.InnerQuery.AddField("target");
            return this;
        }
    }
}