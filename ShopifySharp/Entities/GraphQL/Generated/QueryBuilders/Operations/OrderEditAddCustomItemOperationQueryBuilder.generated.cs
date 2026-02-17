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
    public sealed class OrderEditAddCustomItemOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditAddCustomItemPayload, OrderEditAddCustomItemOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditAddCustomItemPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditAddCustomItemArgumentsBuilder Arguments { get; }
        protected override OrderEditAddCustomItemOperationQueryBuilder Self => this;

        public OrderEditAddCustomItemOperationQueryBuilder() : this("orderEditAddCustomItem")
        {
        }

        public OrderEditAddCustomItemOperationQueryBuilder(string name) : base(new Query<OrderEditAddCustomItemPayload>(name))
        {
            Arguments = new OrderEditAddCustomItemArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddCustomItemOperationQueryBuilder(IQuery<OrderEditAddCustomItemPayload> query) : base(query)
        {
            Arguments = new OrderEditAddCustomItemArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddCustomItemOperationQueryBuilder CalculatedLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("calculatedLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public OrderEditAddCustomItemOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddCustomItemOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddCustomItemOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}