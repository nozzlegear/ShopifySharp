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
    public sealed class DutySaleQueryBuilder : FieldsQueryBuilderBase<DutySale, DutySaleQueryBuilder>
    {
        protected override DutySaleQueryBuilder Self => this;

        public DutySaleQueryBuilder() : this("dutySale")
        {
        }

        public DutySaleQueryBuilder(string name) : base(new Query<DutySale>(name))
        {
        }

        public DutySaleQueryBuilder(IQuery<DutySale> query) : base(query)
        {
        }

        public DutySaleQueryBuilder ActionType()
        {
            base.InnerQuery.AddField("actionType");
            return this;
        }

        public DutySaleQueryBuilder Duty(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder> build)
        {
            var query = new Query<Duty>("duty");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Duty>(query);
            return this;
        }

        public DutySaleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DutySaleQueryBuilder LineType()
        {
            base.InnerQuery.AddField("lineType");
            return this;
        }

        public DutySaleQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public DutySaleQueryBuilder Taxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder> build)
        {
            var query = new Query<SaleTax>("taxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleTaxQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleTax>(query);
            return this;
        }

        public DutySaleQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DutySaleQueryBuilder TotalDiscountAmountAfterTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountAfterTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DutySaleQueryBuilder TotalDiscountAmountBeforeTaxes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDiscountAmountBeforeTaxes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DutySaleQueryBuilder TotalTaxAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}