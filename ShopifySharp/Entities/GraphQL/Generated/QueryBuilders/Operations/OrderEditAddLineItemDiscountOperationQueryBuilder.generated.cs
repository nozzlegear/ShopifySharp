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
    public sealed class OrderEditAddLineItemDiscountOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditAddLineItemDiscountPayload, OrderEditAddLineItemDiscountOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditAddLineItemDiscountPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditAddLineItemDiscountArgumentsBuilder Arguments { get; }
        protected override OrderEditAddLineItemDiscountOperationQueryBuilder Self => this;

        public OrderEditAddLineItemDiscountOperationQueryBuilder() : this("orderEditAddLineItemDiscount")
        {
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder(string name) : base(new Query<OrderEditAddLineItemDiscountPayload>(name))
        {
            Arguments = new OrderEditAddLineItemDiscountArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder(IQuery<OrderEditAddLineItemDiscountPayload> query) : base(query)
        {
            Arguments = new OrderEditAddLineItemDiscountArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder AddedDiscountStagedChange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddLineItemDiscount>("addedDiscountStagedChange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderStagedChangeAddLineItemDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderStagedChangeAddLineItemDiscount>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder CalculatedLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("calculatedLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddLineItemDiscountOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}