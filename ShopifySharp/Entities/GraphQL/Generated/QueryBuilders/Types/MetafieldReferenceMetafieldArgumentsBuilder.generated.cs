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
    public sealed class MetafieldReferenceMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, MetafieldReferenceMetafieldArgumentsBuilder>
    {
        protected override MetafieldReferenceMetafieldArgumentsBuilder Self => this;

        public MetafieldReferenceMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public MetafieldReferenceMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public MetafieldReferenceMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}