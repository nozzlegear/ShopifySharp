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
    public sealed class FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderRejectFulfillmentRequestPayload, FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderRejectFulfillmentRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder() : this("fulfillmentOrderRejectFulfillmentRequest")
        {
        }

        public FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderRejectFulfillmentRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder(IQuery<FulfillmentOrderRejectFulfillmentRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderRejectFulfillmentRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}