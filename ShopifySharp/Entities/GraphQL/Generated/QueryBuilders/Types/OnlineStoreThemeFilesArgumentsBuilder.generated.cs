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
    public sealed class OnlineStoreThemeFilesArgumentsBuilder : ArgumentsBuilderBase<OnlineStoreThemeFileConnection?, OnlineStoreThemeFilesArgumentsBuilder>
    {
        protected override OnlineStoreThemeFilesArgumentsBuilder Self => this;

        public OnlineStoreThemeFilesArgumentsBuilder(IQuery<OnlineStoreThemeFileConnection?> query) : base(query)
        {
        }

        public OnlineStoreThemeFilesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public OnlineStoreThemeFilesArgumentsBuilder Filenames(ICollection<string>? filenames)
        {
            base.InnerQuery.AddArgument("filenames", filenames);
            return this;
        }

        public OnlineStoreThemeFilesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}