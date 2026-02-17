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
    public sealed class CodeDiscountNodeByCodeArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeNode, CodeDiscountNodeByCodeArgumentsBuilder>
    {
        protected override CodeDiscountNodeByCodeArgumentsBuilder Self => this;

        public CodeDiscountNodeByCodeArgumentsBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
        }

        public CodeDiscountNodeByCodeArgumentsBuilder Code(string? code)
        {
            base.InnerQuery.AddArgument("code", code);
            return this;
        }
    }
}