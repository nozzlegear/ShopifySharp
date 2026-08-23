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
    public sealed class ProductVariantResourcePublicationsV2ArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationV2Connection?, ProductVariantResourcePublicationsV2ArgumentsBuilder>
    {
        protected override ProductVariantResourcePublicationsV2ArgumentsBuilder Self => this;

        public ProductVariantResourcePublicationsV2ArgumentsBuilder(IQuery<ResourcePublicationV2Connection?> query) : base(query)
        {
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder CatalogType(CatalogType? catalogType)
        {
            base.InnerQuery.AddArgument("catalogType", catalogType);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }

        public ProductVariantResourcePublicationsV2ArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}