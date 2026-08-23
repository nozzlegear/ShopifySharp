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
    public sealed class CashDrawerCashActivitiesArgumentsBuilder : ArgumentsBuilderBase<CashActivityConnection?, CashDrawerCashActivitiesArgumentsBuilder>
    {
        protected override CashDrawerCashActivitiesArgumentsBuilder Self => this;

        public CashDrawerCashActivitiesArgumentsBuilder(IQuery<CashActivityConnection?> query) : base(query)
        {
        }

        public CashDrawerCashActivitiesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder SortKey(CashActivitiesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public CashDrawerCashActivitiesArgumentsBuilder StaffMemberId(string? staffMemberId)
        {
            base.InnerQuery.AddArgument("staffMemberId", staffMemberId);
            return this;
        }
    }
}