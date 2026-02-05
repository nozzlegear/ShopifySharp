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
    public sealed class FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderAcceptCancellationRequestPayload, FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderAcceptCancellationRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderAcceptCancellationRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder() : this("fulfillmentOrderAcceptCancellationRequest")
        {
        }

        public FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderAcceptCancellationRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderAcceptCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder(IQuery<FulfillmentOrderAcceptCancellationRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderAcceptCancellationRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderAcceptCancellationRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}