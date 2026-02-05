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
    public sealed class ThemeFilesUpsertArgumentsBuilder : ArgumentsBuilderBase<ThemeFilesUpsertPayload, ThemeFilesUpsertArgumentsBuilder>
    {
        protected override ThemeFilesUpsertArgumentsBuilder Self => this;

        public ThemeFilesUpsertArgumentsBuilder(IQuery<ThemeFilesUpsertPayload> query) : base(query)
        {
        }

        public ThemeFilesUpsertArgumentsBuilder Files(ICollection<OnlineStoreThemeFilesUpsertFileInput>? files)
        {
            base.InnerQuery.AddArgument("files", files);
            return this;
        }

        public ThemeFilesUpsertArgumentsBuilder ThemeId(string? themeId)
        {
            base.InnerQuery.AddArgument("themeId", themeId);
            return this;
        }
    }
}