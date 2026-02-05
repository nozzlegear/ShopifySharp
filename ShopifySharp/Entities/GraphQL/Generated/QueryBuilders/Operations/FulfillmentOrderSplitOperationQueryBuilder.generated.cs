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
    public sealed class FulfillmentOrderSplitOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSplitPayload, FulfillmentOrderSplitOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderSplitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderSplitArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderSplitOperationQueryBuilder Self => this;

        public FulfillmentOrderSplitOperationQueryBuilder() : this("fulfillmentOrderSplit")
        {
        }

        public FulfillmentOrderSplitOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderSplitPayload>(name))
        {
            Arguments = new FulfillmentOrderSplitArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSplitOperationQueryBuilder(IQuery<FulfillmentOrderSplitPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderSplitArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderSplitOperationQueryBuilder FulfillmentOrderSplits(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitResultQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderSplitResult>("fulfillmentOrderSplits");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderSplitResult>(query);
            return this;
        }

        public FulfillmentOrderSplitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderSplitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderSplitUserError>(query);
            return this;
        }
    }
}