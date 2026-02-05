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
    public sealed class UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySavedSearchPayload, UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder>
    {
        protected override UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder() : this("urlRedirectBulkDeleteBySavedSearchPayload")
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySavedSearchPayload>(name))
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder(IQuery<UrlRedirectBulkDeleteBySavedSearchPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteBySavedSearchUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteBySavedSearchUserError>(query);
            return this;
        }
    }
}