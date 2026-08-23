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
    public sealed class SaleInterfaceCasesBuilder : InterfaceCasesBuilderBase<ISale, SaleInterfaceCasesBuilder>
    {
        protected override SaleInterfaceCasesBuilder Self => this;

        public SaleInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ISale>(fieldName))
        {
        }

        public SaleInterfaceCasesBuilder(IQuery<ISale> query) : base(query)
        {
        }

        public SaleInterfaceCasesBuilder OnAdditionalFeeSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeSaleQueryBuilder> build)
        {
            var query = new Query<AdditionalFeeSale>("... on AdditionalFeeSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdditionalFeeSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnAdjustmentSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AdjustmentSaleQueryBuilder> build)
        {
            var query = new Query<AdjustmentSale>("... on AdjustmentSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AdjustmentSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnDutySale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DutySaleQueryBuilder> build)
        {
            var query = new Query<DutySale>("... on DutySale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DutySaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnFeeSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FeeSaleQueryBuilder> build)
        {
            var query = new Query<FeeSale>("... on FeeSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FeeSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnGiftCardSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSaleQueryBuilder> build)
        {
            var query = new Query<GiftCardSale>("... on GiftCardSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnProductSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSaleQueryBuilder> build)
        {
            var query = new Query<ProductSale>("... on ProductSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnShippingLineSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineSaleQueryBuilder> build)
        {
            var query = new Query<ShippingLineSale>("... on ShippingLineSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLineSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnTipSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TipSaleQueryBuilder> build)
        {
            var query = new Query<TipSale>("... on TipSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TipSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SaleInterfaceCasesBuilder OnUnknownSale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnknownSaleQueryBuilder> build)
        {
            var query = new Query<UnknownSale>("... on UnknownSale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnknownSaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}