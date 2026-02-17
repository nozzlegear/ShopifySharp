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
    public sealed class ThemeFilesDeleteArgumentsBuilder : ArgumentsBuilderBase<ThemeFilesDeletePayload, ThemeFilesDeleteArgumentsBuilder>
    {
        protected override ThemeFilesDeleteArgumentsBuilder Self => this;

        public ThemeFilesDeleteArgumentsBuilder(IQuery<ThemeFilesDeletePayload> query) : base(query)
        {
        }

        public ThemeFilesDeleteArgumentsBuilder Files(ICollection<string>? files)
        {
            base.InnerQuery.AddArgument("files", files);
            return this;
        }

        public ThemeFilesDeleteArgumentsBuilder ThemeId(string? themeId)
        {
            base.InnerQuery.AddArgument("themeId", themeId);
            return this;
        }
    }
}