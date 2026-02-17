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
    public sealed class ThemeFilesCopyArgumentsBuilder : ArgumentsBuilderBase<ThemeFilesCopyPayload, ThemeFilesCopyArgumentsBuilder>
    {
        protected override ThemeFilesCopyArgumentsBuilder Self => this;

        public ThemeFilesCopyArgumentsBuilder(IQuery<ThemeFilesCopyPayload> query) : base(query)
        {
        }

        public ThemeFilesCopyArgumentsBuilder Files(ICollection<ThemeFilesCopyFileInput>? files)
        {
            base.InnerQuery.AddArgument("files", files);
            return this;
        }

        public ThemeFilesCopyArgumentsBuilder ThemeId(string? themeId)
        {
            base.InnerQuery.AddArgument("themeId", themeId);
            return this;
        }
    }
}