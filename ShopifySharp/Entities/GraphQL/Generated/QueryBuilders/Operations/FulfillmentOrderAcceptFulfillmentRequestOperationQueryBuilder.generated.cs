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
    public sealed class FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderAcceptFulfillmentRequestPayload, FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderAcceptFulfillmentRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder() : this("fulfillmentOrderAcceptFulfillmentRequest")
        {
        }

        public FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderAcceptFulfillmentRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder(IQuery<FulfillmentOrderAcceptFulfillmentRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderAcceptFulfillmentRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}