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
    public sealed class MetafieldReferenceVariantsInCollectionArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, MetafieldReferenceVariantsInCollectionArgumentsBuilder>
    {
        protected override MetafieldReferenceVariantsInCollectionArgumentsBuilder Self => this;

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferenceVariantsInCollectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}