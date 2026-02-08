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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class EventBridgeServerPixelUpdateOperationQueryBuilder : FieldsQueryBuilderBase<EventBridgeServerPixelUpdatePayload, EventBridgeServerPixelUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<EventBridgeServerPixelUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public EventBridgeServerPixelUpdateArgumentsBuilder Arguments { get; }
        protected override EventBridgeServerPixelUpdateOperationQueryBuilder Self => this;

        public EventBridgeServerPixelUpdateOperationQueryBuilder() : this("eventBridgeServerPixelUpdate")
        {
        }

        public EventBridgeServerPixelUpdateOperationQueryBuilder(string name) : base(new Query<EventBridgeServerPixelUpdatePayload>(name))
        {
            Arguments = new EventBridgeServerPixelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeServerPixelUpdateOperationQueryBuilder(IQuery<EventBridgeServerPixelUpdatePayload> query) : base(query)
        {
            Arguments = new EventBridgeServerPixelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeServerPixelUpdateOperationQueryBuilder ServerPixel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder> build)
        {
            var query = new Query<ServerPixel>("serverPixel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ServerPixelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ServerPixel>(query);
            return this;
        }

        public EventBridgeServerPixelUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder> build)
        {
            var query = new Query<ErrorsServerPixelUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ErrorsServerPixelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ErrorsServerPixelUserError>(query);
            return this;
        }
    }
}