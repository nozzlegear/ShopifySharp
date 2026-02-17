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
    public sealed class FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrdersSetFulfillmentDeadlinePayload, FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrdersSetFulfillmentDeadlinePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder Self => this;

        public FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder() : this("fulfillmentOrdersSetFulfillmentDeadline")
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder(string name) : base(new Query<FulfillmentOrdersSetFulfillmentDeadlinePayload>(name))
        {
            Arguments = new FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder(IQuery<FulfillmentOrdersSetFulfillmentDeadlinePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder Success()
        {
            base.InnerQuery.AddField("success");
            return this;
        }

        public FulfillmentOrdersSetFulfillmentDeadlineOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrdersSetFulfillmentDeadlineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrdersSetFulfillmentDeadlineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrdersSetFulfillmentDeadlineUserError>(query);
            return this;
        }
    }
}