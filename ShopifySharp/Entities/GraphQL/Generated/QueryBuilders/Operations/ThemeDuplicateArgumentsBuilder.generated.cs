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