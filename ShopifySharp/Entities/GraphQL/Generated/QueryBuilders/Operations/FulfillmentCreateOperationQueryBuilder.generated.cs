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
    public sealed class FulfillmentCreateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentCreatePayload, FulfillmentCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentCreateArgumentsBuilder Arguments { get; }
        protected override FulfillmentCreateOperationQueryBuilder Self => this;

        public FulfillmentCreateOperationQueryBuilder() : this("fulfillmentCreate")
        {
        }

        public FulfillmentCreateOperationQueryBuilder(string name) : base(new Query<FulfillmentCreatePayload>(name))
        {
            Arguments = new FulfillmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCreateOperationQueryBuilder(IQuery<FulfillmentCreatePayload> query) : base(query)
        {
            Arguments = new FulfillmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentCreateOperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}