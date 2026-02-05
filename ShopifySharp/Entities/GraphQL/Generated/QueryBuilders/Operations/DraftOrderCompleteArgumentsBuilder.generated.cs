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
    public sealed class DraftOrderCompleteArgumentsBuilder : ArgumentsBuilderBase<DraftOrderCompletePayload, DraftOrderCompleteArgumentsBuilder>
    {
        protected override DraftOrderCompleteArgumentsBuilder Self => this;

        public DraftOrderCompleteArgumentsBuilder(IQuery<DraftOrderCompletePayload> query) : base(query)
        {
        }

        public DraftOrderCompleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public DraftOrderCompleteArgumentsBuilder PaymentGatewayId(string? paymentGatewayId)
        {
            base.InnerQuery.AddArgument("paymentGatewayId", paymentGatewayId);
            return this;
        }

        public DraftOrderCompleteArgumentsBuilder SourceName(string? sourceName)
        {
            base.InnerQuery.AddArgument("sourceName", sourceName);
            return this;
        }
    }
}