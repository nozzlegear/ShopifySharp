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
    public sealed class FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSubmitCancellationRequestPayload, FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder>
    {
        protected override FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder Self => this;

        public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder() : this("fulfillmentOrderSubmitCancellationRequestPayload")
        {
        }

        public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderSubmitCancellationRequestPayload>(name))
        {
        }

        public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder(IQuery<FulfillmentOrderSubmitCancellationRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}