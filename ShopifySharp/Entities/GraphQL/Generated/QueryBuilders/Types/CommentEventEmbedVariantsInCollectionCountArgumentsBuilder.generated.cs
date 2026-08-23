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
    public sealed class CommentEventEmbedVariantsInCollectionCountArgumentsBuilder : ArgumentsBuilderBase<Count?, CommentEventEmbedVariantsInCollectionCountArgumentsBuilder>
    {
        protected override CommentEventEmbedVariantsInCollectionCountArgumentsBuilder Self => this;

        public CommentEventEmbedVariantsInCollectionCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public CommentEventEmbedVariantsInCollectionCountArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }
    }
}