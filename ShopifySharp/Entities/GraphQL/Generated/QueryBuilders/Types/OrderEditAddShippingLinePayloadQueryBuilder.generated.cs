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
    public sealed class OrderEditAddShippingLinePayloadQueryBuilder : FieldsQueryBuilderBase<OrderEditAddShippingLinePayload, OrderEditAddShippingLinePayloadQueryBuilder>
    {
        protected override OrderEditAddShippingLinePayloadQueryBuilder Self => this;

        public OrderEditAddShippingLinePayloadQueryBuilder() : this("orderEditAddShippingLinePayload")
        {
        }

        public OrderEditAddShippingLinePayloadQueryBuilder(string name) : base(new Query<OrderEditAddShippingLinePayload>(name))
        {
        }

        public OrderEditAddShippingLinePayloadQueryBuilder(IQuery<OrderEditAddShippingLinePayload> query) : base(query)
        {
        }

        public OrderEditAddShippingLinePayloadQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddShippingLinePayloadQueryBuilder CalculatedShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder> build)
        {
            var query = new Query<CalculatedShippingLine>("calculatedShippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedShippingLine>(query);
            return this;
        }

        public OrderEditAddShippingLinePayloadQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddShippingLinePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditAddShippingLineUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditAddShippingLineUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditAddShippingLineUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditAddShippingLineUserError>(query);
            return this;
        }
    }
}