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
    public sealed class MetafieldReferencerOrderTagsArgumentsBuilder : ArgumentsBuilderBase<StringConnection?, MetafieldReferencerOrderTagsArgumentsBuilder>
    {
        protected override MetafieldReferencerOrderTagsArgumentsBuilder Self => this;

        public MetafieldReferencerOrderTagsArgumentsBuilder(IQuery<StringConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerOrderTagsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerOrderTagsArgumentsBuilder Sort(ShopTagSort? sort)
        {
            base.InnerQuery.AddArgument("sort", sort);
            return this;
        }
    }
}