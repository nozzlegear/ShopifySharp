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
    public sealed class CashDrawerTotalRefundsArgumentsBuilder : ArgumentsBuilderBase<MoneyV2?, CashDrawerTotalRefundsArgumentsBuilder>
    {
        protected override CashDrawerTotalRefundsArgumentsBuilder Self => this;

        public CashDrawerTotalRefundsArgumentsBuilder(IQuery<MoneyV2?> query) : base(query)
        {
        }

        public CashDrawerTotalRefundsArgumentsBuilder DateRange(CashDrawerDateRangeInput? dateRange)
        {
            base.InnerQuery.AddArgument("dateRange", dateRange);
            return this;
        }
    }
}