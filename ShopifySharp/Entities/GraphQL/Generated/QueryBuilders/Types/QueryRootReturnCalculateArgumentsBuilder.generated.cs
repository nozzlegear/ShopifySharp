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
    public sealed class QueryRootReturnCalculateArgumentsBuilder : ArgumentsBuilderBase<CalculatedReturn?, QueryRootReturnCalculateArgumentsBuilder>
    {
        protected override QueryRootReturnCalculateArgumentsBuilder Self => this;

        public QueryRootReturnCalculateArgumentsBuilder(IQuery<CalculatedReturn?> query) : base(query)
        {
        }

        public QueryRootReturnCalculateArgumentsBuilder Input(CalculateReturnInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}