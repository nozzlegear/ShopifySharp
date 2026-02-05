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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class TaxSummaryCreateArgumentsBuilder : ArgumentsBuilderBase<TaxSummaryCreatePayload, TaxSummaryCreateArgumentsBuilder>
    {
        protected override TaxSummaryCreateArgumentsBuilder Self => this;

        public TaxSummaryCreateArgumentsBuilder(IQuery<TaxSummaryCreatePayload> query) : base(query)
        {
        }

        public TaxSummaryCreateArgumentsBuilder EndTime(DateTimeOffset? endTime)
        {
            base.InnerQuery.AddArgument("endTime", endTime);
            return this;
        }

        public TaxSummaryCreateArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }

        public TaxSummaryCreateArgumentsBuilder StartTime(DateTimeOffset? startTime)
        {
            base.InnerQuery.AddArgument("startTime", startTime);
            return this;
        }
    }
}