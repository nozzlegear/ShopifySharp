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
    public sealed class FulfillmentOrderMergeOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMergePayload, FulfillmentOrderMergeOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderMergePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderMergeArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderMergeOperationQueryBuilder Self => this;

        public FulfillmentOrderMergeOperationQueryBuilder() : this("fulfillmentOrderMerge")
        {
        }

        public FulfillmentOrderMergeOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderMergePayload>(name))
        {
            Arguments = new FulfillmentOrderMergeArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMergeOperationQueryBuilder(IQuery<FulfillmentOrderMergePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderMergeArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMergeOperationQueryBuilder FulfillmentOrderMerges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeResultQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMergeResult>("fulfillmentOrderMerges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMergeResult>(query);
            return this;
        }

        public FulfillmentOrderMergeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMergeUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMergeUserError>(query);
            return this;
        }
    }
}