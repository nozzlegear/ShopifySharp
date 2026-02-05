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
    public sealed class UrlRedirectBulkDeleteBySearchPayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectBulkDeleteBySearchPayload, UrlRedirectBulkDeleteBySearchPayloadQueryBuilder>
    {
        protected override UrlRedirectBulkDeleteBySearchPayloadQueryBuilder Self => this;

        public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder() : this("urlRedirectBulkDeleteBySearchPayload")
        {
        }

        public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder(string name) : base(new Query<UrlRedirectBulkDeleteBySearchPayload>(name))
        {
        }

        public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder(IQuery<UrlRedirectBulkDeleteBySearchPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectBulkDeleteBySearchUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectBulkDeleteBySearchUserError>(query);
            return this;
        }
    }
}