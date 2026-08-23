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
    public sealed class UnknownSaleQueryBuilder : FieldsQueryBuilderBase<UnknownSale, UnknownSaleQueryBuilder>
    {
        protected override UnknownSaleQueryBuilder Self => this;

        public UnknownSaleQueryBuilder() : this("unknownSale")
        {
        }

        public UnknownSaleQueryBuilder(string name) : base(new Query<UnknownSale>(name))
        {
        }

        public UnknownSaleQueryBuilder(IQuery<UnknownSale> query) : base(query)
        {
        }

        public UnknownSaleQueryBuilder ActionType()
        {
            base.InnerQuery.AddField("actionType");
            return this;
        }

        public UnknownSaleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UnknownSaleQueryBuilder LineType()
        {
            base.InnerQuery.AddField("lineType");
            return this;
        }

        public UnknownSaleQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public UnknownSaleQueryBuilder Taxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder> build)
        {
            var query = new Query<SaleTax>("taxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleTax>(query);
            return this;
        }

        public UnknownSaleQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public UnknownSaleQueryBuilder TotalDiscountAmountAfterTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountAfterTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public UnknownSaleQueryBuilder TotalDiscountAmountBeforeTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountBeforeTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public UnknownSaleQueryBuilder TotalTaxAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}