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
    public sealed class UrlRedirectUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectUpdatePayload, UrlRedirectUpdatePayloadQueryBuilder>
    {
        protected override UrlRedirectUpdatePayloadQueryBuilder Self => this;

        public UrlRedirectUpdatePayloadQueryBuilder() : this("urlRedirectUpdatePayload")
        {
        }

        public UrlRedirectUpdatePayloadQueryBuilder(string name) : base(new Query<UrlRedirectUpdatePayload>(name))
        {
        }

        public UrlRedirectUpdatePayloadQueryBuilder(IQuery<UrlRedirectUpdatePayload> query) : base(query)
        {
        }

        public UrlRedirectUpdatePayloadQueryBuilder UrlRedirect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("urlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}