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
    public sealed class FulfillmentCancelOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentCancelPayload, FulfillmentCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentCancelArgumentsBuilder Arguments { get; }
        protected override FulfillmentCancelOperationQueryBuilder Self => this;

        public FulfillmentCancelOperationQueryBuilder() : this("fulfillmentCancel")
        {
        }

        public FulfillmentCancelOperationQueryBuilder(string name) : base(new Query<FulfillmentCancelPayload>(name))
        {
            Arguments = new FulfillmentCancelArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCancelOperationQueryBuilder(IQuery<FulfillmentCancelPayload> query) : base(query)
        {
            Arguments = new FulfillmentCancelArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCancelOperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}