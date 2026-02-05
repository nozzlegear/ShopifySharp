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
    public sealed class TagsAddArgumentsBuilder : ArgumentsBuilderBase<TagsAddPayload, TagsAddArgumentsBuilder>
    {
        protected override TagsAddArgumentsBuilder Self => this;

        public TagsAddArgumentsBuilder(IQuery<TagsAddPayload> query) : base(query)
        {
        }

        public TagsAddArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public TagsAddArgumentsBuilder Tags(ICollection<string>? tags)
        {
            base.InnerQuery.AddArgument("tags", tags);
            return this;
        }
    }
}