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
    public sealed class TagsRemoveArgumentsBuilder : ArgumentsBuilderBase<TagsRemovePayload, TagsRemoveArgumentsBuilder>
    {
        protected override TagsRemoveArgumentsBuilder Self => this;

        public TagsRemoveArgumentsBuilder(IQuery<TagsRemovePayload> query) : base(query)
        {
        }

        public TagsRemoveArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public TagsRemoveArgumentsBuilder Tags(ICollection<string>? tags)
        {
            base.InnerQuery.AddArgument("tags", tags);
            return this;
        }
    }
}