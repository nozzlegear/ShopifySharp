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
    public sealed class CalculatedReturnArgumentsBuilder : ArgumentsBuilderBase<CalculatedReturn, CalculatedReturnArgumentsBuilder>
    {
        protected override CalculatedReturnArgumentsBuilder Self => this;

        public CalculatedReturnArgumentsBuilder(IQuery<CalculatedReturn> query) : base(query)
        {
        }

        public CalculatedReturnArgumentsBuilder Input(CalculateReturnInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}