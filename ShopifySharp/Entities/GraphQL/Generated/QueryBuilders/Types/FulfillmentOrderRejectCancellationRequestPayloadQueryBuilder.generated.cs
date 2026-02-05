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
    public sealed class FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderRejectCancellationRequestPayload, FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder>
    {
        protected override FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder Self => this;

        public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder() : this("fulfillmentOrderRejectCancellationRequestPayload")
        {
        }

        public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderRejectCancellationRequestPayload>(name))
        {
        }

        public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder(IQuery<FulfillmentOrderRejectCancellationRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}