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
    public sealed class FulfillmentOrderMoveOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMovePayload, FulfillmentOrderMoveOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderMovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderMoveArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderMoveOperationQueryBuilder Self => this;

        public FulfillmentOrderMoveOperationQueryBuilder() : this("fulfillmentOrderMove")
        {
        }

        public FulfillmentOrderMoveOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderMovePayload>(name))
        {
            Arguments = new FulfillmentOrderMoveArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMoveOperationQueryBuilder(IQuery<FulfillmentOrderMovePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderMoveArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMoveOperationQueryBuilder MovedFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("movedFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderMoveOperationQueryBuilder OriginalFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("originalFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderMoveOperationQueryBuilder RemainingFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("remainingFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderMoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}