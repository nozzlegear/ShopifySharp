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
    public sealed class UrlRedirectCreatePayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectCreatePayload, UrlRedirectCreatePayloadQueryBuilder>
    {
        protected override UrlRedirectCreatePayloadQueryBuilder Self => this;

        public UrlRedirectCreatePayloadQueryBuilder() : this("urlRedirectCreatePayload")
        {
        }

        public UrlRedirectCreatePayloadQueryBuilder(string name) : base(new Query<UrlRedirectCreatePayload>(name))
        {
        }

        public UrlRedirectCreatePayloadQueryBuilder(IQuery<UrlRedirectCreatePayload> query) : base(query)
        {
        }

        public UrlRedirectCreatePayloadQueryBuilder UrlRedirect(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder> build)
        {
            var query = new Query<UrlRedirect>("urlRedirect");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirect>(query);
            return this;
        }

        public UrlRedirectCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}