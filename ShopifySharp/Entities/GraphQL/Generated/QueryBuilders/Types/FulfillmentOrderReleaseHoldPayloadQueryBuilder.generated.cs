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
    public sealed class FulfillmentOrderReleaseHoldPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReleaseHoldPayload, FulfillmentOrderReleaseHoldPayloadQueryBuilder>
    {
        protected override FulfillmentOrderReleaseHoldPayloadQueryBuilder Self => this;

        public FulfillmentOrderReleaseHoldPayloadQueryBuilder() : this("fulfillmentOrderReleaseHoldPayload")
        {
        }

        public FulfillmentOrderReleaseHoldPayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderReleaseHoldPayload>(name))
        {
        }

        public FulfillmentOrderReleaseHoldPayloadQueryBuilder(IQuery<FulfillmentOrderReleaseHoldPayload> query) : base(query)
        {
        }

        public FulfillmentOrderReleaseHoldPayloadQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderReleaseHoldPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderReleaseHoldUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderReleaseHoldUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderReleaseHoldUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderReleaseHoldUserError>(query);
            return this;
        }
    }
}