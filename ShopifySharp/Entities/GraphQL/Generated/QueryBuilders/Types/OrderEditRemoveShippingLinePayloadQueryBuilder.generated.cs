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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class OrderEditRemoveShippingLinePayloadQueryBuilder : FieldsQueryBuilderBase<OrderEditRemoveShippingLinePayload, OrderEditRemoveShippingLinePayloadQueryBuilder>
    {
        protected override OrderEditRemoveShippingLinePayloadQueryBuilder Self => this;

        public OrderEditRemoveShippingLinePayloadQueryBuilder() : this("orderEditRemoveShippingLinePayload")
        {
        }

        public OrderEditRemoveShippingLinePayloadQueryBuilder(string name) : base(new Query<OrderEditRemoveShippingLinePayload>(name))
        {
        }

        public OrderEditRemoveShippingLinePayloadQueryBuilder(IQuery<OrderEditRemoveShippingLinePayload> query) : base(query)
        {
        }

        public OrderEditRemoveShippingLinePayloadQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditRemoveShippingLinePayloadQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditRemoveShippingLinePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditRemoveShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditRemoveShippingLineUserError>(query);
            return this;
        }
    }
}