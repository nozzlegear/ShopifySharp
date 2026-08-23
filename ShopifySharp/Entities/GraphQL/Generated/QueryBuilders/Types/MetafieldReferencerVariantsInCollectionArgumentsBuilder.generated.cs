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
    public sealed class MetafieldReferencerVariantsInCollectionArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, MetafieldReferencerVariantsInCollectionArgumentsBuilder>
    {
        protected override MetafieldReferencerVariantsInCollectionArgumentsBuilder Self => this;

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerVariantsInCollectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}