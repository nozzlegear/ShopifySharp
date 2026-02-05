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
    public sealed class UrlRedirectBulkDeleteByIdsPayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteByIdsPayload, UrlRedirectBulkDeleteByIdsPayloadQueryBuilder>
    {
        protected override UrlRedirectBulkDeleteByIdsPayloadQueryBuilder Self => this;

        public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder() : this("urlRedirectBulkDeleteByIdsPayload")
        {
        }

        public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteByIdsPayload>(name))
        {
        }

        public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder(IQuery<UrlRedirectBulkDeleteByIdsPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteByIdsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteByIdsUserError>(query);
            return this;
        }
    }
}