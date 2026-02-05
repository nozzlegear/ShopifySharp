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
    public sealed class FulfillmentOrderCloseOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderClosePayload, FulfillmentOrderCloseOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderClosePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderCloseArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderCloseOperationQueryBuilder Self => this;

        public FulfillmentOrderCloseOperationQueryBuilder() : this("fulfillmentOrderClose")
        {
        }

        public FulfillmentOrderCloseOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderClosePayload>(name))
        {
            Arguments = new FulfillmentOrderCloseArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderCloseOperationQueryBuilder(IQuery<FulfillmentOrderClosePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderCloseArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderCloseOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderCloseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}