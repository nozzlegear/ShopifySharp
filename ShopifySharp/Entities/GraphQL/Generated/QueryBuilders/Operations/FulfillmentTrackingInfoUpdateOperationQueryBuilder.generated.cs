#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentTrackingInfoUpdateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentTrackingInfoUpdatePayload, FulfillmentTrackingInfoUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentTrackingInfoUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentTrackingInfoUpdateArgumentsBuilder Arguments { get; }
        protected override FulfillmentTrackingInfoUpdateOperationQueryBuilder Self => this;

        public FulfillmentTrackingInfoUpdateOperationQueryBuilder() : this("fulfillmentTrackingInfoUpdate")
        {
        }

        public FulfillmentTrackingInfoUpdateOperationQueryBuilder(string name) : base(new Query<FulfillmentTrackingInfoUpdatePayload>(name))
        {
            Arguments = new FulfillmentTrackingInfoUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentTrackingInfoUpdateOperationQueryBuilder(IQuery<FulfillmentTrackingInfoUpdatePayload> query) : base(query)
        {
            Arguments = new FulfillmentTrackingInfoUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentTrackingInfoUpdateOperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentTrackingInfoUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}