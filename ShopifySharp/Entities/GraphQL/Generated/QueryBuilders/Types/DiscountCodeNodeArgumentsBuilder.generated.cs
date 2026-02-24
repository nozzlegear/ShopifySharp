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
    public sealed class DiscountCodeNodeArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeNode, DiscountCodeNodeArgumentsBuilder>
    {
        protected override DiscountCodeNodeArgumentsBuilder Self => this;

        public DiscountCodeNodeArgumentsBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
        }

        public DiscountCodeNodeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public DiscountCodeNodeArgumentsBuilder Code(string? code)
        {
            base.InnerQuery.AddArgument("code", code);
            return this;
        }
    }
}