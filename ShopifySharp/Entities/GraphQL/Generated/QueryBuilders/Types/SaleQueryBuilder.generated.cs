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
    public sealed class SaleQueryBuilder : FieldsQueryBuilderBase<ISale, SaleQueryBuilder>
    {
        protected override SaleQueryBuilder Self => this;

        public SaleQueryBuilder() : this("sale")
        {
        }

        public SaleQueryBuilder(string name) : base(new Query<ISale>(name))
        {
        }

        public SaleQueryBuilder(IQuery<ISale> query) : base(query)
        {
        }

        public SaleQueryBuilder ActionType()
        {
            base.InnerQuery.AddField("actionType");
            return this;
        }

        public SaleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SaleQueryBuilder LineType()
        {
            base.InnerQuery.AddField("lineType");
            return this;
        }

        public SaleQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public SaleQueryBuilder Taxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder> build)
        {
            var query = new Query<SaleTax>("taxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleTax>(query);
            return this;
        }

        public SaleQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SaleQueryBuilder TotalDiscountAmountAfterTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountAfterTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SaleQueryBuilder TotalDiscountAmountBeforeTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountBeforeTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SaleQueryBuilder TotalTaxAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SaleQueryBuilder OnAdditionalFeeSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeSaleQueryBuilder> build)
        {
            var query = new Query<AdditionalFeeSale>("... on AdditionalFeeSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnAdjustmentSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdjustmentSaleQueryBuilder> build)
        {
            var query = new Query<AdjustmentSale>("... on AdjustmentSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdjustmentSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnDutySale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DutySaleQueryBuilder> build)
        {
            var query = new Query<DutySale>("... on DutySale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DutySaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnFeeSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FeeSaleQueryBuilder> build)
        {
            var query = new Query<FeeSale>("... on FeeSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FeeSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnGiftCardSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSaleQueryBuilder> build)
        {
            var query = new Query<GiftCardSale>("... on GiftCardSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnProductSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSaleQueryBuilder> build)
        {
            var query = new Query<ProductSale>("... on ProductSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnShippingLineSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineSaleQueryBuilder> build)
        {
            var query = new Query<ShippingLineSale>("... on ShippingLineSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnTipSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TipSaleQueryBuilder> build)
        {
            var query = new Query<TipSale>("... on TipSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TipSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder OnUnknownSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnknownSaleQueryBuilder> build)
        {
            var query = new Query<UnknownSale>("... on UnknownSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnknownSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SaleQueryBuilder Sale(Action<SaleInterfaceCasesBuilder> build)
        {
            var query = new Query<ISale>("sale");
            var unionBuilder = new SaleInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}