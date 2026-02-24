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
    public sealed class SearchResultConnectionArgumentsBuilder : ArgumentsBuilderBase<SearchResultConnection, SearchResultConnectionArgumentsBuilder>
    {
        protected override SearchResultConnectionArgumentsBuilder Self => this;

        public SearchResultConnectionArgumentsBuilder(IQuery<SearchResultConnection> query) : base(query)
        {
        }

        public SearchResultConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SearchResultConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SearchResultConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public SearchResultConnectionArgumentsBuilder Types(ICollection<SearchResultType>? types)
        {
            base.InnerQuery.AddArgument("types", types);
            return this;
        }
    }
}