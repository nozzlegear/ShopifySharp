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
    public sealed class CashTrackingSessionAdjustmentsArgumentsBuilder : ArgumentsBuilderBase<CashTrackingAdjustmentConnection?, CashTrackingSessionAdjustmentsArgumentsBuilder>
    {
        protected override CashTrackingSessionAdjustmentsArgumentsBuilder Self => this;

        public CashTrackingSessionAdjustmentsArgumentsBuilder(IQuery<CashTrackingAdjustmentConnection?> query) : base(query)
        {
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CashTrackingSessionAdjustmentsArgumentsBuilder SortKey(AdjustmentsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}