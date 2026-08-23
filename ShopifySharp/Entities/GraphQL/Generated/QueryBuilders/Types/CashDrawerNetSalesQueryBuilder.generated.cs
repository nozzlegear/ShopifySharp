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
    public sealed class CashDrawerNetSalesQueryBuilder : FieldsQueryBuilderBase<MoneyV2, CashDrawerNetSalesQueryBuilder>, IHasArguments<CashDrawerNetSalesArgumentsBuilder>
    {
        public CashDrawerNetSalesArgumentsBuilder Arguments { get; }
        protected override CashDrawerNetSalesQueryBuilder Self => this;

        public CashDrawerNetSalesQueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new CashDrawerNetSalesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerNetSalesQueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new CashDrawerNetSalesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerNetSalesQueryBuilder SetArguments(Action<CashDrawerNetSalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerNetSalesQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CashDrawerNetSalesQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}