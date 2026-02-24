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
    public sealed class QueryRootCodeDiscountNodeByCodeArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeNode?, QueryRootCodeDiscountNodeByCodeArgumentsBuilder>
    {
        protected override QueryRootCodeDiscountNodeByCodeArgumentsBuilder Self => this;

        public QueryRootCodeDiscountNodeByCodeArgumentsBuilder(IQuery<DiscountCodeNode?> query) : base(query)
        {
        }

        public QueryRootCodeDiscountNodeByCodeArgumentsBuilder Code(string? code)
        {
            base.InnerQuery.AddArgument("code", code);
            return this;
        }
    }
}