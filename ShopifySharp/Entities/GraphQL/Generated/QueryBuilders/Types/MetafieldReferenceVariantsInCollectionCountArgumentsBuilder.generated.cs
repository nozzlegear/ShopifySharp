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
    public sealed class MetafieldReferenceVariantsInCollectionCountArgumentsBuilder : ArgumentsBuilderBase<Count?, MetafieldReferenceVariantsInCollectionCountArgumentsBuilder>
    {
        protected override MetafieldReferenceVariantsInCollectionCountArgumentsBuilder Self => this;

        public MetafieldReferenceVariantsInCollectionCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public MetafieldReferenceVariantsInCollectionCountArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }
    }
}