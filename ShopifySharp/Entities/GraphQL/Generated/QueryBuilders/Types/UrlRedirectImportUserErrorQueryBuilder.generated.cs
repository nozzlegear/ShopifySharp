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
    public sealed class UrlRedirectImportUserErrorQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportUserError, UrlRedirectImportUserErrorQueryBuilder>
    {
        protected override UrlRedirectImportUserErrorQueryBuilder Self => this;

        public UrlRedirectImportUserErrorQueryBuilder() : this("urlRedirectImportUserError")
        {
        }

        public UrlRedirectImportUserErrorQueryBuilder(string name) : base(new Query<UrlRedirectImportUserError>(name))
        {
        }

        public UrlRedirectImportUserErrorQueryBuilder(IQuery<UrlRedirectImportUserError> query) : base(query)
        {
        }

        public UrlRedirectImportUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public UrlRedirectImportUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public UrlRedirectImportUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}