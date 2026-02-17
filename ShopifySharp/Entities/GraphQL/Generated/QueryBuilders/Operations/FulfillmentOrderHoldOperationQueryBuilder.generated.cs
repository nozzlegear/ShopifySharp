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
    public sealed class FulfillmentOrderHoldOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderHoldPayload, FulfillmentOrderHoldOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderHoldPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderHoldArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderHoldOperationQueryBuilder Self => this;

        public FulfillmentOrderHoldOperationQueryBuilder() : this("fulfillmentOrderHold")
        {
        }

        public FulfillmentOrderHoldOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderHoldPayload>(name))
        {
            Arguments = new FulfillmentOrderHoldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderHoldOperationQueryBuilder(IQuery<FulfillmentOrderHoldPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderHoldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderHoldOperationQueryBuilder FulfillmentHold(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder> build)
        {
            var query = new Query<FulfillmentHold>("fulfillmentHold");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentHold>(query);
            return this;
        }

        public FulfillmentOrderHoldOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderHoldOperationQueryBuilder RemainingFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("remainingFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderHoldOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderHoldUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderHoldUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderHoldUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderHoldUserError>(query);
            return this;
        }
    }
}