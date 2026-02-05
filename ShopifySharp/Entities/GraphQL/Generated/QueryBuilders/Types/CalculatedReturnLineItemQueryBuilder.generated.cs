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
    public sealed class CalculatedReturnLineItemQueryBuilder : FieldsQueryBuilderBase<CalculatedReturnLineItem, CalculatedReturnLineItemQueryBuilder>
    {
        protected override CalculatedReturnLineItemQueryBuilder Self => this;

        public CalculatedReturnLineItemQueryBuilder() : this("calculatedReturnLineItem")
        {
        }

        public CalculatedReturnLineItemQueryBuilder(string name) : base(new Query<CalculatedReturnLineItem>(name))
        {
        }

        public CalculatedReturnLineItemQueryBuilder(IQuery<CalculatedReturnLineItem> query) : base(query)
        {
        }

        public CalculatedReturnLineItemQueryBuilder FulfillmentLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("fulfillmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder RestockingFee(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedRestockingFeeQueryBuilder> build)
        {
            var query = new Query<CalculatedRestockingFee>("restockingFee");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedRestockingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedRestockingFee>(query);
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder SubtotalBeforeOrderDiscountsSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalBeforeOrderDiscountsSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder SubtotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedReturnLineItemQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}