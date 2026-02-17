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
    public sealed class FulfillmentOrderOpenOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderOpenPayload, FulfillmentOrderOpenOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderOpenPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderOpenArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderOpenOperationQueryBuilder Self => this;

        public FulfillmentOrderOpenOperationQueryBuilder() : this("fulfillmentOrderOpen")
        {
        }

        public FulfillmentOrderOpenOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderOpenPayload>(name))
        {
            Arguments = new FulfillmentOrderOpenArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderOpenOperationQueryBuilder(IQuery<FulfillmentOrderOpenPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderOpenArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderOpenOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderOpenOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}