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
    public sealed class AdjustmentSaleQueryBuilder : FieldsQueryBuilderBase<AdjustmentSale, AdjustmentSaleQueryBuilder>
    {
        protected override AdjustmentSaleQueryBuilder Self => this;

        public AdjustmentSaleQueryBuilder() : this("adjustmentSale")
        {
        }

        public AdjustmentSaleQueryBuilder(string name) : base(new Query<AdjustmentSale>(name))
        {
        }

        public AdjustmentSaleQueryBuilder(IQuery<AdjustmentSale> query) : base(query)
        {
        }

        public AdjustmentSaleQueryBuilder ActionType()
        {
            base.InnerQuery.AddField("actionType");
            return this;
        }

        public AdjustmentSaleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AdjustmentSaleQueryBuilder LineType()
        {
            base.InnerQuery.AddField("lineType");
            return this;
        }

        public AdjustmentSaleQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public AdjustmentSaleQueryBuilder Taxes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleTaxQueryBuilder> build)
        {
            var query = new Query<SaleTax>("taxes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleTaxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleTax>(query);
            return this;
        }

        public AdjustmentSaleQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AdjustmentSaleQueryBuilder TotalDiscountAmountAfterTaxes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountAfterTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AdjustmentSaleQueryBuilder TotalDiscountAmountBeforeTaxes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountBeforeTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public AdjustmentSaleQueryBuilder TotalTaxAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}