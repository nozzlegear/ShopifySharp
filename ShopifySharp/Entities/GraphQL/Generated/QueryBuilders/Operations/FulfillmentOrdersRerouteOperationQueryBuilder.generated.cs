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
    public sealed class FulfillmentOrdersRerouteOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrdersReroutePayload, FulfillmentOrdersRerouteOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrdersReroutePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrdersRerouteArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrdersRerouteOperationQueryBuilder Self => this;

        public FulfillmentOrdersRerouteOperationQueryBuilder() : this("fulfillmentOrdersReroute")
        {
        }

        public FulfillmentOrdersRerouteOperationQueryBuilder(string name) : base(new Query<FulfillmentOrdersReroutePayload>(name))
        {
            Arguments = new FulfillmentOrdersRerouteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrdersRerouteOperationQueryBuilder(IQuery<FulfillmentOrdersReroutePayload> query) : base(query)
        {
            Arguments = new FulfillmentOrdersRerouteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrdersRerouteOperationQueryBuilder MovedFulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("movedFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrdersRerouteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrdersRerouteUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrdersRerouteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrdersRerouteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrdersRerouteUserError>(query);
            return this;
        }
    }
}