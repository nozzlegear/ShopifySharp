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