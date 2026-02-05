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
    public sealed class ServerPixelCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ServerPixelCreatePayload, ServerPixelCreatePayloadQueryBuilder>
    {
        protected override ServerPixelCreatePayloadQueryBuilder Self => this;

        public ServerPixelCreatePayloadQueryBuilder() : this("serverPixelCreatePayload")
        {
        }

        public ServerPixelCreatePayloadQueryBuilder(string name) : base(new Query<ServerPixelCreatePayload>(name))
        {
        }

        public ServerPixelCreatePayloadQueryBuilder(IQuery<ServerPixelCreatePayload> query) : base(query)
        {
        }

        public ServerPixelCreatePayloadQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public ServerPixelCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}