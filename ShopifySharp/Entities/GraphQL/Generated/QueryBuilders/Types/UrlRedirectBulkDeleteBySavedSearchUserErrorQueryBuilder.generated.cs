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
    public sealed class UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySavedSearchUserError, UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder>
    {
        protected override UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder() : this("urlRedirectBulkDeleteBySavedSearchUserError")
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySavedSearchUserError>(name))
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder(IQuery<UrlRedirectBulkDeleteBySavedSearchUserError> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}