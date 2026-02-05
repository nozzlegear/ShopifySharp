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
    public sealed class FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSubmitFulfillmentRequestPayload, FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderSubmitFulfillmentRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder Self => this;

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder() : this("fulfillmentOrderSubmitFulfillmentRequest")
        {
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderSubmitFulfillmentRequestPayload>(name))
        {
            Arguments = new FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder(IQuery<FulfillmentOrderSubmitFulfillmentRequestPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder OriginalFulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("originalFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder SubmittedFulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("submittedFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder UnsubmittedFulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("unsubmittedFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}