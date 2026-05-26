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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentOrderReportProgressArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderReportProgressPayload, FulfillmentOrderReportProgressArgumentsBuilder>
    {
        protected override FulfillmentOrderReportProgressArgumentsBuilder Self => this;

        public FulfillmentOrderReportProgressArgumentsBuilder(IQuery<FulfillmentOrderReportProgressPayload> query) : base(query)
        {
        }

        public FulfillmentOrderReportProgressArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderReportProgressArgumentsBuilder ProgressReport(FulfillmentOrderReportProgressInput? progressReport)
        {
            base.InnerQuery.AddArgument("progressReport", progressReport);
            return this;
        }
    }
}