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
    public sealed class ShopSearchArgumentsBuilder : ArgumentsBuilderBase<SearchResultConnection?, ShopSearchArgumentsBuilder>
    {
        protected override ShopSearchArgumentsBuilder Self => this;

        public ShopSearchArgumentsBuilder(IQuery<SearchResultConnection?> query) : base(query)
        {
        }

        public ShopSearchArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopSearchArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopSearchArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopSearchArgumentsBuilder Types(ICollection<SearchResultType>? types)
        {
            base.InnerQuery.AddArgument("types", types);
            return this;
        }
    }
}