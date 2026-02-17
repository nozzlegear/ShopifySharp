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
    public sealed class FulfillmentOrderRejectCancellationRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderRejectCancellationRequestPayload, FulfillmentOrderRejectCancellationRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderRejectCancellationRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderRejectCancellationRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderRejectCancellationRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderRejectCancellationRequestOperationQueryBuilder() : this("fulfillmentOrderRejectCancellationRequest")
        {
        }

        public FulfillmentOrderRejectCancellationRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderRejectCancellationRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderRejectCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRejectCancellationRequestOperationQueryBuilder(IQuery<FulfillmentOrderRejectCancellationRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderRejectCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRejectCancellationRequestOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderRejectCancellationRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}