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
    public sealed class FulfillmentServiceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentServiceUpdatePayload, FulfillmentServiceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentServiceUpdatePayload>, IHasArguments<FulfillmentServiceUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentServiceUpdateArgumentsBuilder Arguments { get; }
        protected override FulfillmentServiceUpdateOperationQueryBuilder Self => this;

        public FulfillmentServiceUpdateOperationQueryBuilder() : this("fulfillmentServiceUpdate")
        {
        }

        public FulfillmentServiceUpdateOperationQueryBuilder(string name) : base(new Query<FulfillmentServiceUpdatePayload>(name))
        {
            Arguments = new FulfillmentServiceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceUpdateOperationQueryBuilder(IQuery<FulfillmentServiceUpdatePayload> query) : base(query)
        {
            Arguments = new FulfillmentServiceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceUpdateOperationQueryBuilder SetArguments(Action<FulfillmentServiceUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentServiceUpdateOperationQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public FulfillmentServiceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}