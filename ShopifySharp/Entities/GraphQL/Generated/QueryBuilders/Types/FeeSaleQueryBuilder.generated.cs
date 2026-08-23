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
    public sealed class FeeSaleQueryBuilder : FieldsQueryBuilderBase<FeeSale, FeeSaleQueryBuilder>
    {
        protected override FeeSaleQueryBuilder Self => this;

        public FeeSaleQueryBuilder() : this("feeSale")
        {
        }

        public FeeSaleQueryBuilder(string name) : base(new Query<FeeSale>(name))
        {
        }

        public FeeSaleQueryBuilder(IQuery<FeeSale> query) : base(query)
        {
        }

        public FeeSaleQueryBuilder ActionType()
        {
            base.InnerQuery.AddField("actionType");
            return this;
        }

        public FeeSaleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FeeSaleQueryBuilder LineType()
        {
            base.InnerQuery.AddField("lineType");
            return this;
        }

        public FeeSaleQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public FeeSaleQueryBuilder Taxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder> build)
        {
            var query = new Query<SaleTax>("taxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleTax>(query);
            return this;
        }

        public FeeSaleQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FeeSaleQueryBuilder TotalDiscountAmountAfterTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountAfterTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FeeSaleQueryBuilder TotalDiscountAmountBeforeTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountBeforeTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FeeSaleQueryBuilder TotalTaxAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FeeSaleQueryBuilder Fee(Action<FeeInterfaceCasesBuilder> build)
        {
            var query = new Query<IFee>("fee");
            var unionBuilder = new FeeInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}