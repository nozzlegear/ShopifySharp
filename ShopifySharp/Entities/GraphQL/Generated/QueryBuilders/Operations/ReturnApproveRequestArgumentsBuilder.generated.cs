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