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
    [Obsolete("Use `fulfillmentCreate` instead.")]
    public sealed class FulfillmentCreateV2OperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentCreateV2Payload, FulfillmentCreateV2OperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentCreateV2Payload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentCreateV2ArgumentsBuilder Arguments { get; }
        protected override FulfillmentCreateV2OperationQueryBuilder Self => this;

        public FulfillmentCreateV2OperationQueryBuilder() : this("fulfillmentCreateV2")
        {
        }

        public FulfillmentCreateV2OperationQueryBuilder(string name) : base(new Query<FulfillmentCreateV2Payload>(name))
        {
            Arguments = new FulfillmentCreateV2ArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCreateV2OperationQueryBuilder(IQuery<FulfillmentCreateV2Payload> query) : base(query)
        {
            Arguments = new FulfillmentCreateV2ArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCreateV2OperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentCreateV2OperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}