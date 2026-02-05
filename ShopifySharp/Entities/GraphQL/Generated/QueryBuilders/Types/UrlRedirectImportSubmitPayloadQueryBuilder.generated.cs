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
    public sealed class UrlRedirectImportSubmitPayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportSubmitPayload, UrlRedirectImportSubmitPayloadQueryBuilder>
    {
        protected override UrlRedirectImportSubmitPayloadQueryBuilder Self => this;

        public UrlRedirectImportSubmitPayloadQueryBuilder() : this("urlRedirectImportSubmitPayload")
        {
        }

        public UrlRedirectImportSubmitPayloadQueryBuilder(string name) : base(new Query<UrlRedirectImportSubmitPayload>(name))
        {
        }

        public UrlRedirectImportSubmitPayloadQueryBuilder(IQuery<UrlRedirectImportSubmitPayload> query) : base(query)
        {
        }

        public UrlRedirectImportSubmitPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public UrlRedirectImportSubmitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}