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
    public sealed class CashDrawerTotalSalesQueryBuilder : FieldsQueryBuilderBase<MoneyV2, CashDrawerTotalSalesQueryBuilder>, IHasArguments<CashDrawerTotalSalesArgumentsBuilder>
    {
        public CashDrawerTotalSalesArgumentsBuilder Arguments { get; }
        protected override CashDrawerTotalSalesQueryBuilder Self => this;

        public CashDrawerTotalSalesQueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new CashDrawerTotalSalesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalSalesQueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new CashDrawerTotalSalesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerTotalSalesQueryBuilder SetArguments(Action<CashDrawerTotalSalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerTotalSalesQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CashDrawerTotalSalesQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}