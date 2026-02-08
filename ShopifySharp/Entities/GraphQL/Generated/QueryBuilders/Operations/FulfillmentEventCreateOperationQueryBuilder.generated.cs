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
    public sealed class FulfillmentEventCreateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentEventCreatePayload, FulfillmentEventCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentEventCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentEventCreateArgumentsBuilder Arguments { get; }
        protected override FulfillmentEventCreateOperationQueryBuilder Self => this;

        public FulfillmentEventCreateOperationQueryBuilder() : this("fulfillmentEventCreate")
        {
        }

        public FulfillmentEventCreateOperationQueryBuilder(string name) : base(new Query<FulfillmentEventCreatePayload>(name))
        {
            Arguments = new FulfillmentEventCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentEventCreateOperationQueryBuilder(IQuery<FulfillmentEventCreatePayload> query) : base(query)
        {
            Arguments = new FulfillmentEventCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentEventCreateOperationQueryBuilder FulfillmentEvent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("fulfillmentEvent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEvent>(query);
            return this;
        }

        public FulfillmentEventCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}