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
    public sealed class ReturnApproveRequestArgumentsBuilder : ArgumentsBuilderBase<ReturnApproveRequestPayload, ReturnApproveRequestArgumentsBuilder>
    {
        protected override ReturnApproveRequestArgumentsBuilder Self => this;

        public ReturnApproveRequestArgumentsBuilder(IQuery<ReturnApproveRequestPayload> query) : base(query)
        {
        }

        public ReturnApproveRequestArgumentsBuilder Input(ReturnApproveRequestInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}