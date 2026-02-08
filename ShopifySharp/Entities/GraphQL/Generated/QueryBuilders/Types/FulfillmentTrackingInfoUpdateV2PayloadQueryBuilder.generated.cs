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
    public sealed class FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentTrackingInfoUpdateV2Payload, FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder>
    {
        protected override FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder Self => this;

        public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder() : this("fulfillmentTrackingInfoUpdateV2Payload")
        {
        }

        public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder(string name) : base(new Query<FulfillmentTrackingInfoUpdateV2Payload>(name))
        {
        }

        public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder(IQuery<FulfillmentTrackingInfoUpdateV2Payload> query) : base(query)
        {
        }

        public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}