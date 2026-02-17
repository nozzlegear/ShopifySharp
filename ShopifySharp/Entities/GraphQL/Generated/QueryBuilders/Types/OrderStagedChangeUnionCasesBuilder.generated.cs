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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class OrderStagedChangeUnionCasesBuilder : UnionCasesBuilderBase<OrderStagedChange, OrderStagedChangeUnionCasesBuilder>
    {
        protected override OrderStagedChangeUnionCasesBuilder Self => this;

        public OrderStagedChangeUnionCasesBuilder(string fieldName = "node") : this(new Query<OrderStagedChange>(fieldName))
        {
        }

        public OrderStagedChangeUnionCasesBuilder(IQuery<OrderStagedChange> query) : base(query)
        {
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeAddCustomItem(Action<OrderStagedChangeAddCustomItemQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddCustomItem>("... on OrderStagedChangeAddCustomItem");
            var queryBuilder = new OrderStagedChangeAddCustomItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeAddLineItemDiscount(Action<OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddLineItemDiscount>("... on OrderStagedChangeAddLineItemDiscount");
            var queryBuilder = new OrderStagedChangeAddLineItemDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeAddShippingLine(Action<OrderStagedChangeAddShippingLineQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddShippingLine>("... on OrderStagedChangeAddShippingLine");
            var queryBuilder = new OrderStagedChangeAddShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeAddVariant(Action<OrderStagedChangeAddVariantQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeAddVariant>("... on OrderStagedChangeAddVariant");
            var queryBuilder = new OrderStagedChangeAddVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeDecrementItem(Action<OrderStagedChangeDecrementItemQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeDecrementItem>("... on OrderStagedChangeDecrementItem");
            var queryBuilder = new OrderStagedChangeDecrementItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeIncrementItem(Action<OrderStagedChangeIncrementItemQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeIncrementItem>("... on OrderStagedChangeIncrementItem");
            var queryBuilder = new OrderStagedChangeIncrementItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeRemoveDiscount(Action<OrderStagedChangeRemoveDiscountQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeRemoveDiscount>("... on OrderStagedChangeRemoveDiscount");
            var queryBuilder = new OrderStagedChangeRemoveDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public OrderStagedChangeUnionCasesBuilder OnOrderStagedChangeRemoveShippingLine(Action<OrderStagedChangeRemoveShippingLineQueryBuilder> build)
        {
            var query = new Query<OrderStagedChangeRemoveShippingLine>("... on OrderStagedChangeRemoveShippingLine");
            var queryBuilder = new OrderStagedChangeRemoveShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}