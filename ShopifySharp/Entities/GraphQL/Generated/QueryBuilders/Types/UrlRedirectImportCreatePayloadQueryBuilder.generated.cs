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
    public sealed class UrlRedirectImportCreatePayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectImportCreatePayload, UrlRedirectImportCreatePayloadQueryBuilder>
    {
        protected override UrlRedirectImportCreatePayloadQueryBuilder Self => this;

        public UrlRedirectImportCreatePayloadQueryBuilder() : this("urlRedirectImportCreatePayload")
        {
        }

        public UrlRedirectImportCreatePayloadQueryBuilder(string name) : base(new Query<UrlRedirectImportCreatePayload>(name))
        {
        }

        public UrlRedirectImportCreatePayloadQueryBuilder(IQuery<UrlRedirectImportCreatePayload> query) : base(query)
        {
        }

        public UrlRedirectImportCreatePayloadQueryBuilder UrlRedirectImport(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImport>("urlRedirectImport");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImport>(query);
            return this;
        }

        public UrlRedirectImportCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectImportUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectImportUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectImportUserError>(query);
            return this;
        }
    }
}