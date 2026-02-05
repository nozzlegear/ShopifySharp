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
    public sealed class DraftOrderAppliedDiscountQueryBuilder : FieldsQueryBuilderBase<DraftOrderAppliedDiscount, DraftOrderAppliedDiscountQueryBuilder>
    {
        protected override DraftOrderAppliedDiscountQueryBuilder Self => this;

        public DraftOrderAppliedDiscountQueryBuilder() : this("draftOrderAppliedDiscount")
        {
        }

        public DraftOrderAppliedDiscountQueryBuilder(string name) : base(new Query<DraftOrderAppliedDiscount>(name))
        {
        }

        public DraftOrderAppliedDiscountQueryBuilder(IQuery<DraftOrderAppliedDiscount> query) : base(query)
        {
        }

        [Obsolete("Use `amountSet` instead.")]
        public DraftOrderAppliedDiscountQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder AmountV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amountV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public DraftOrderAppliedDiscountQueryBuilder ValueType()
        {
            base.InnerQuery.AddField("valueType");
            return this;
        }
    }
}