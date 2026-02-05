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
    public sealed class WebPixelDeletePayloadQueryBuilder : FieldsQueryBuilderBase<WebPixelDeletePayload, WebPixelDeletePayloadQueryBuilder>
    {
        protected override WebPixelDeletePayloadQueryBuilder Self => this;

        public WebPixelDeletePayloadQueryBuilder() : this("webPixelDeletePayload")
        {
        }

        public WebPixelDeletePayloadQueryBuilder(string name) : base(new Query<WebPixelDeletePayload>(name))
        {
        }

        public WebPixelDeletePayloadQueryBuilder(IQuery<WebPixelDeletePayload> query) : base(query)
        {
        }

        public WebPixelDeletePayloadQueryBuilder DeletedWebPixelId()
        {
            base.InnerQuery.AddField("deletedWebPixelId");
            return this;
        }

        public WebPixelDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsWebPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsWebPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsWebPixelUserError>(query);
            return this;
        }
    }
}