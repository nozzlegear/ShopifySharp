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
    public sealed class UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySearchUserError, UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder>
    {
        protected override UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder() : this("urlRedirectBulkDeleteBySearchUserError")
        {
        }

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySearchUserError>(name))
        {
        }

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder(IQuery<UrlRedirectBulkDeleteBySearchUserError> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}