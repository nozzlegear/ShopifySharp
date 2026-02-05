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
    public sealed class OrderEditRemoveDiscountPayloadQueryBuilder : FieldsQueryBuilderBase<OrderEditRemoveDiscountPayload, OrderEditRemoveDiscountPayloadQueryBuilder>
    {
        protected override OrderEditRemoveDiscountPayloadQueryBuilder Self => this;

        public OrderEditRemoveDiscountPayloadQueryBuilder() : this("orderEditRemoveDiscountPayload")
        {
        }

        public OrderEditRemoveDiscountPayloadQueryBuilder(string name) : base(new Query<OrderEditRemoveDiscountPayload>(name))
        {
        }

        public OrderEditRemoveDiscountPayloadQueryBuilder(IQuery<OrderEditRemoveDiscountPayload> query) : base(query)
        {
        }

        public OrderEditRemoveDiscountPayloadQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditRemoveDiscountPayloadQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditRemoveDiscountPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveDiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderEditRemoveDiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditRemoveDiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditRemoveDiscountUserError>(query);
            return this;
        }
    }
}