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
    public sealed class CurrencyExchangeAdjustmentQueryBuilder : FieldsQueryBuilderBase<CurrencyExchangeAdjustment, CurrencyExchangeAdjustmentQueryBuilder>
    {
        protected override CurrencyExchangeAdjustmentQueryBuilder Self => this;

        public CurrencyExchangeAdjustmentQueryBuilder() : this("currencyExchangeAdjustment")
        {
        }

        public CurrencyExchangeAdjustmentQueryBuilder(string name) : base(new Query<CurrencyExchangeAdjustment>(name))
        {
        }

        public CurrencyExchangeAdjustmentQueryBuilder(IQuery<CurrencyExchangeAdjustment> query) : base(query)
        {
        }

        public CurrencyExchangeAdjustmentQueryBuilder Adjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("adjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CurrencyExchangeAdjustmentQueryBuilder FinalAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("finalAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CurrencyExchangeAdjustmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CurrencyExchangeAdjustmentQueryBuilder OriginalAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("originalAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}