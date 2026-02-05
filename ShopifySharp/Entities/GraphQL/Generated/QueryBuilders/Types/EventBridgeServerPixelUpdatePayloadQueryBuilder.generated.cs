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
    public sealed class EventBridgeServerPixelUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<EventBridgeServerPixelUpdatePayload, EventBridgeServerPixelUpdatePayloadQueryBuilder>
    {
        protected override EventBridgeServerPixelUpdatePayloadQueryBuilder Self => this;

        public EventBridgeServerPixelUpdatePayloadQueryBuilder() : this("eventBridgeServerPixelUpdatePayload")
        {
        }

        public EventBridgeServerPixelUpdatePayloadQueryBuilder(string name) : base(new Query<EventBridgeServerPixelUpdatePayload>(name))
        {
        }

        public EventBridgeServerPixelUpdatePayloadQueryBuilder(IQuery<EventBridgeServerPixelUpdatePayload> query) : base(query)
        {
        }

        public EventBridgeServerPixelUpdatePayloadQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public EventBridgeServerPixelUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}