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
    public sealed class UrlRedirectDeletePayloadQueryBuilder : FieldsQueryBuilderBase<UrlRedirectDeletePayload, UrlRedirectDeletePayloadQueryBuilder>
    {
        protected override UrlRedirectDeletePayloadQueryBuilder Self => this;

        public UrlRedirectDeletePayloadQueryBuilder() : this("urlRedirectDeletePayload")
        {
        }

        public UrlRedirectDeletePayloadQueryBuilder(string name) : base(new Query<UrlRedirectDeletePayload>(name))
        {
        }

        public UrlRedirectDeletePayloadQueryBuilder(IQuery<UrlRedirectDeletePayload> query) : base(query)
        {
        }

        public UrlRedirectDeletePayloadQueryBuilder DeletedUrlRedirectId()
        {
            base.InnerQuery.AddField("deletedUrlRedirectId");
            return this;
        }

        public UrlRedirectDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder> build)
        {
            var query = new Query<UrlRedirectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UrlRedirectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UrlRedirectUserError>(query);
            return this;
        }
    }
}