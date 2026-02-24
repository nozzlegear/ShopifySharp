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
    public sealed class MetafieldReferencerSearchArgumentsBuilder : ArgumentsBuilderBase<SearchResultConnection?, MetafieldReferencerSearchArgumentsBuilder>
    {
        protected override MetafieldReferencerSearchArgumentsBuilder Self => this;

        public MetafieldReferencerSearchArgumentsBuilder(IQuery<SearchResultConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerSearchArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerSearchArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerSearchArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldReferencerSearchArgumentsBuilder Types(ICollection<SearchResultType>? types)
        {
            base.InnerQuery.AddArgument("types", types);
            return this;
        }
    }
}