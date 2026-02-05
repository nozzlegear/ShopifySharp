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
    public sealed class DiscountNodeArgumentsBuilder : ArgumentsBuilderBase<DiscountNode, DiscountNodeArgumentsBuilder>
    {
        protected override DiscountNodeArgumentsBuilder Self => this;

        public DiscountNodeArgumentsBuilder(IQuery<DiscountNode> query) : base(query)
        {
        }

        public DiscountNodeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}