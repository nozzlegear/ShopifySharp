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
    public sealed class FulfillmentOrderRescheduleOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReschedulePayload, FulfillmentOrderRescheduleOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderReschedulePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderRescheduleArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderRescheduleOperationQueryBuilder Self => this;

        public FulfillmentOrderRescheduleOperationQueryBuilder() : this("fulfillmentOrderReschedule")
        {
        }

        public FulfillmentOrderRescheduleOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderReschedulePayload>(name))
        {
            Arguments = new FulfillmentOrderRescheduleArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRescheduleOperationQueryBuilder(IQuery<FulfillmentOrderReschedulePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderRescheduleArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderRescheduleOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderRescheduleOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderRescheduleUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderRescheduleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderRescheduleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderRescheduleUserError>(query);
            return this;
        }
    }
}