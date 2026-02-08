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
    public sealed class FulfillmentOrderReschedulePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReschedulePayload, FulfillmentOrderReschedulePayloadQueryBuilder>
    {
        protected override FulfillmentOrderReschedulePayloadQueryBuilder Self => this;

        public FulfillmentOrderReschedulePayloadQueryBuilder() : this("fulfillmentOrderReschedulePayload")
        {
        }

        public FulfillmentOrderReschedulePayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderReschedulePayload>(name))
        {
        }

        public FulfillmentOrderReschedulePayloadQueryBuilder(IQuery<FulfillmentOrderReschedulePayload> query) : base(query)
        {
        }

        public FulfillmentOrderReschedulePayloadQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderReschedulePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderRescheduleUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderRescheduleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderRescheduleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderRescheduleUserError>(query);
            return this;
        }
    }
}