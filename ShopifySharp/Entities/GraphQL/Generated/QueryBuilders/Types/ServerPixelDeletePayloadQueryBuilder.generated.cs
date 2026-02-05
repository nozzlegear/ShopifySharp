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
    public sealed class ServerPixelDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ServerPixelDeletePayload, ServerPixelDeletePayloadQueryBuilder>
    {
        protected override ServerPixelDeletePayloadQueryBuilder Self => this;

        public ServerPixelDeletePayloadQueryBuilder() : this("serverPixelDeletePayload")
        {
        }

        public ServerPixelDeletePayloadQueryBuilder(string name) : base(new Query<ServerPixelDeletePayload>(name))
        {
        }

        public ServerPixelDeletePayloadQueryBuilder(IQuery<ServerPixelDeletePayload> query) : base(query)
        {
        }

        public ServerPixelDeletePayloadQueryBuilder DeletedServerPixelId()
        {
            base.InnerQuery.AddField("deletedServerPixelId");
            return this;
        }

        public ServerPixelDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}