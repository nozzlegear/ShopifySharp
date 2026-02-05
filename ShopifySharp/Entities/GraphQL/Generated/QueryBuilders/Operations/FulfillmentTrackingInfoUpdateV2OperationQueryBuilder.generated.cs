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
    [Obsolete("Use `fulfillmentTrackingInfoUpdate` instead.")]
    public sealed class FulfillmentTrackingInfoUpdateV2OperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentTrackingInfoUpdateV2Payload, FulfillmentTrackingInfoUpdateV2OperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentTrackingInfoUpdateV2Payload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentTrackingInfoUpdateV2ArgumentsBuilder Arguments { get; }
        protected override FulfillmentTrackingInfoUpdateV2OperationQueryBuilder Self => this;

        public FulfillmentTrackingInfoUpdateV2OperationQueryBuilder() : this("fulfillmentTrackingInfoUpdateV2")
        {
        }

        public FulfillmentTrackingInfoUpdateV2OperationQueryBuilder(string name) : base(new Query<FulfillmentTrackingInfoUpdateV2Payload>(name))
        {
            Arguments = new FulfillmentTrackingInfoUpdateV2ArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentTrackingInfoUpdateV2OperationQueryBuilder(IQuery<FulfillmentTrackingInfoUpdateV2Payload> query) : base(query)
        {
            Arguments = new FulfillmentTrackingInfoUpdateV2ArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentTrackingInfoUpdateV2OperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentTrackingInfoUpdateV2OperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}