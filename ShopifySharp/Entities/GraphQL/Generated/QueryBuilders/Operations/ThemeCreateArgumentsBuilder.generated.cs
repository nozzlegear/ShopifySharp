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
    public sealed class ThemeCreateArgumentsBuilder : ArgumentsBuilderBase<ThemeCreatePayload, ThemeCreateArgumentsBuilder>
    {
        protected override ThemeCreateArgumentsBuilder Self => this;

        public ThemeCreateArgumentsBuilder(IQuery<ThemeCreatePayload> query) : base(query)
        {
        }

        public ThemeCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public ThemeCreateArgumentsBuilder Role(ThemeRole? role)
        {
            base.InnerQuery.AddArgument("role", role);
            return this;
        }

        public ThemeCreateArgumentsBuilder Source(string? source)
        {
            base.InnerQuery.AddArgument("source", source);
            return this;
        }
    }
}