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
    public sealed class FulfillmentOrderReleaseHoldOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReleaseHoldPayload, FulfillmentOrderReleaseHoldOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderReleaseHoldPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderReleaseHoldArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderReleaseHoldOperationQueryBuilder Self => this;

        public FulfillmentOrderReleaseHoldOperationQueryBuilder() : this("fulfillmentOrderReleaseHold")
        {
        }

        public FulfillmentOrderReleaseHoldOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderReleaseHoldPayload>(name))
        {
            Arguments = new FulfillmentOrderReleaseHoldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderReleaseHoldOperationQueryBuilder(IQuery<FulfillmentOrderReleaseHoldPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderReleaseHoldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderReleaseHoldOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderReleaseHoldOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderReleaseHoldUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderReleaseHoldUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderReleaseHoldUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderReleaseHoldUserError>(query);
            return this;
        }
    }
}