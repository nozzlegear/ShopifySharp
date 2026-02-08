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
    public sealed class ReturnCreateArgumentsBuilder : ArgumentsBuilderBase<ReturnCreatePayload, ReturnCreateArgumentsBuilder>
    {
        protected override ReturnCreateArgumentsBuilder Self => this;

        public ReturnCreateArgumentsBuilder(IQuery<ReturnCreatePayload> query) : base(query)
        {
        }

        public ReturnCreateArgumentsBuilder ReturnInput(ReturnInput? returnInput)
        {
            base.InnerQuery.AddArgument("returnInput", returnInput);
            return this;
        }
    }
}