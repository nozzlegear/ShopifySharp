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
    public sealed class DiscountCodeNodeMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, DiscountCodeNodeMetafieldArgumentsBuilder>
    {
        protected override DiscountCodeNodeMetafieldArgumentsBuilder Self => this;

        public DiscountCodeNodeMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public DiscountCodeNodeMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public DiscountCodeNodeMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}