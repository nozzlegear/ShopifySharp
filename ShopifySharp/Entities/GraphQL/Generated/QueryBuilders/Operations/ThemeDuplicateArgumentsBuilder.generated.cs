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
    public sealed class ThemeDuplicateArgumentsBuilder : ArgumentsBuilderBase<ThemeDuplicatePayload, ThemeDuplicateArgumentsBuilder>
    {
        protected override ThemeDuplicateArgumentsBuilder Self => this;

        public ThemeDuplicateArgumentsBuilder(IQuery<ThemeDuplicatePayload> query) : base(query)
        {
        }

        public ThemeDuplicateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ThemeDuplicateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }
    }
}