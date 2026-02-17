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
    public sealed class FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSubmitCancellationRequestPayload, FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderSubmitCancellationRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderSubmitCancellationRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder() : this("fulfillmentOrderSubmitCancellationRequest")
        {
        }

        public FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderSubmitCancellationRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderSubmitCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder(IQuery<FulfillmentOrderSubmitCancellationRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderSubmitCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderSubmitCancellationRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}