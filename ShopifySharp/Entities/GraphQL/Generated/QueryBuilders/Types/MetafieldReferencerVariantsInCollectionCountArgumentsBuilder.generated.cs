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
    public sealed class MetafieldReferencerVariantsInCollectionCountArgumentsBuilder : ArgumentsBuilderBase<Count?, MetafieldReferencerVariantsInCollectionCountArgumentsBuilder>
    {
        protected override MetafieldReferencerVariantsInCollectionCountArgumentsBuilder Self => this;

        public MetafieldReferencerVariantsInCollectionCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public MetafieldReferencerVariantsInCollectionCountArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }
    }
}