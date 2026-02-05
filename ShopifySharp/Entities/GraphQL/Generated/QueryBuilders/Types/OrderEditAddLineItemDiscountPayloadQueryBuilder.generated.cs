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
    public sealed class OrderEditAddLineItemDiscountPayloadQueryBuilder : FieldsQueryBuilderBase<OrderEditAddLineItemDiscountPayload, OrderEditAddLineItemDiscountPayloadQueryBuilder>
    {
        protected override OrderEditAddLineItemDiscountPayloadQueryBuilder Self => this;

        public OrderEditAddLineItemDiscountPayloadQueryBuilder() : this("orderEditAddLineItemDiscountPayload")
        {
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder(string name) : base(new Query<OrderEditAddLineItemDiscountPayload>(name))
        {
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder(IQuery<OrderEditAddLineItemDiscountPayload> query) : base(query)
        {
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder AddedDiscountStagedChange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddLineItemDiscount>("addedDiscountStagedChange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeAddLineItemDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderStagedChangeAddLineItemDiscount>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder CalculatedLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("calculatedLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}