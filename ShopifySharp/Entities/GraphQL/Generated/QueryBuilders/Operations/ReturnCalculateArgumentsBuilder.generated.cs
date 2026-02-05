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
    public sealed class ReturnCalculateArgumentsBuilder : ArgumentsBuilderBase<CalculatedReturn, ReturnCalculateArgumentsBuilder>
    {
        protected override ReturnCalculateArgumentsBuilder Self => this;

        public ReturnCalculateArgumentsBuilder(IQuery<CalculatedReturn> query) : base(query)
        {
        }

        public ReturnCalculateArgumentsBuilder Input(CalculateReturnInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}