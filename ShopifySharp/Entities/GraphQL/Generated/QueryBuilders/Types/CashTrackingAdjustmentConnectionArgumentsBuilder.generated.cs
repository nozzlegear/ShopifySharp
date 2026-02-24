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
    public sealed class CashTrackingAdjustmentConnectionArgumentsBuilder : ArgumentsBuilderBase<CashTrackingAdjustmentConnection, CashTrackingAdjustmentConnectionArgumentsBuilder>
    {
        protected override CashTrackingAdjustmentConnectionArgumentsBuilder Self => this;

        public CashTrackingAdjustmentConnectionArgumentsBuilder(IQuery<CashTrackingAdjustmentConnection> query) : base(query)
        {
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CashTrackingAdjustmentConnectionArgumentsBuilder SortKey(AdjustmentsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}