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
    public sealed class FulfillmentServiceCreateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentServiceCreatePayload, FulfillmentServiceCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentServiceCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentServiceCreateArgumentsBuilder Arguments { get; }
        protected override FulfillmentServiceCreateOperationQueryBuilder Self => this;

        public FulfillmentServiceCreateOperationQueryBuilder() : this("fulfillmentServiceCreate")
        {
        }

        public FulfillmentServiceCreateOperationQueryBuilder(string name) : base(new Query<FulfillmentServiceCreatePayload>(name))
        {
            Arguments = new FulfillmentServiceCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceCreateOperationQueryBuilder(IQuery<FulfillmentServiceCreatePayload> query) : base(query)
        {
            Arguments = new FulfillmentServiceCreateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceCreateOperationQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public FulfillmentServiceCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}