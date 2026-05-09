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
    public sealed class CashDrawerTotalRefundsQueryBuilder : FieldsQueryBuilderBase<MoneyV2, CashDrawerTotalRefundsQueryBuilder>, IHasArguments<CashDrawerTotalRefundsArgumentsBuilder>
    {
        public CashDrawerTotalRefundsArgumentsBuilder Arguments { get; }
        protected override CashDrawerTotalRefundsQueryBuilder Self => this;

        public CashDrawerTotalRefundsQueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new CashDrawerTotalRefundsArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalRefundsQueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new CashDrawerTotalRefundsArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalRefundsQueryBuilder SetArguments(Action<CashDrawerTotalRefundsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerTotalRefundsQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CashDrawerTotalRefundsQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}