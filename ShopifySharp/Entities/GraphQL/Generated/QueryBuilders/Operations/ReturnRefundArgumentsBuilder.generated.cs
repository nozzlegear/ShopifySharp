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
    public sealed class ReturnRefundArgumentsBuilder : ArgumentsBuilderBase<ReturnRefundPayload, ReturnRefundArgumentsBuilder>
    {
        protected override ReturnRefundArgumentsBuilder Self => this;

        public ReturnRefundArgumentsBuilder(IQuery<ReturnRefundPayload> query) : base(query)
        {
        }

        public ReturnRefundArgumentsBuilder ReturnRefundInput(ReturnRefundInput? returnRefundInput)
        {
            base.InnerQuery.AddArgument("returnRefundInput", returnRefundInput);
            return this;
        }
    }
}