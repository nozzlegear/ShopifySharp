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
    public sealed class CashDrawerTotalDiscrepanciesQueryBuilder : FieldsQueryBuilderBase<MoneyV2, CashDrawerTotalDiscrepanciesQueryBuilder>, IHasArguments<CashDrawerTotalDiscrepanciesArgumentsBuilder>
    {
        public CashDrawerTotalDiscrepanciesArgumentsBuilder Arguments { get; }
        protected override CashDrawerTotalDiscrepanciesQueryBuilder Self => this;

        public CashDrawerTotalDiscrepanciesQueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new CashDrawerTotalDiscrepanciesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalDiscrepanciesQueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new CashDrawerTotalDiscrepanciesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalDiscrepanciesQueryBuilder SetArguments(Action<CashDrawerTotalDiscrepanciesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerTotalDiscrepanciesQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CashDrawerTotalDiscrepanciesQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}