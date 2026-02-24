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
    public sealed class MetafieldReferenceOptionsArgumentsBuilder : ArgumentsBuilderBase<ProductOption?, MetafieldReferenceOptionsArgumentsBuilder>
    {
        protected override MetafieldReferenceOptionsArgumentsBuilder Self => this;

        public MetafieldReferenceOptionsArgumentsBuilder(IQuery<ProductOption?> query) : base(query)
        {
        }

        public MetafieldReferenceOptionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}