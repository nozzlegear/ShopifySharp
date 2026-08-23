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
    public sealed class ProductVariantsInCollectionArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, ProductVariantsInCollectionArgumentsBuilder>
    {
        protected override ProductVariantsInCollectionArgumentsBuilder Self => this;

        public ProductVariantsInCollectionArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public ProductVariantsInCollectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ProductVariantsInCollectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ProductVariantsInCollectionArgumentsBuilder CollectionId(string? collectionId)
        {
            base.InnerQuery.AddArgument("collectionId", collectionId);
            return this;
        }

        public ProductVariantsInCollectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ProductVariantsInCollectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}