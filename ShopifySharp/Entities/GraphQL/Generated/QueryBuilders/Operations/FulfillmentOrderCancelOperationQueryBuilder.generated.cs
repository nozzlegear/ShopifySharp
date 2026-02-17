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
    public sealed class FulfillmentOrderCancelOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderCancelPayload, FulfillmentOrderCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderCancelArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderCancelOperationQueryBuilder Self => this;

        public FulfillmentOrderCancelOperationQueryBuilder() : this("fulfillmentOrderCancel")
        {
        }

        public FulfillmentOrderCancelOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderCancelPayload>(name))
        {
            Arguments = new FulfillmentOrderCancelArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderCancelOperationQueryBuilder(IQuery<FulfillmentOrderCancelPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderCancelArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderCancelOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderCancelOperationQueryBuilder ReplacementFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("replacementFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}