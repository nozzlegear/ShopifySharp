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
    public sealed class FlowGenerateSignatureArgumentsBuilder : ArgumentsBuilderBase<FlowGenerateSignaturePayload, FlowGenerateSignatureArgumentsBuilder>
    {
        protected override FlowGenerateSignatureArgumentsBuilder Self => this;

        public FlowGenerateSignatureArgumentsBuilder(IQuery<FlowGenerateSignaturePayload> query) : base(query)
        {
        }

        public FlowGenerateSignatureArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FlowGenerateSignatureArgumentsBuilder Payload(string? payload)
        {
            base.InnerQuery.AddArgument("payload", payload);
            return this;
        }
    }
}