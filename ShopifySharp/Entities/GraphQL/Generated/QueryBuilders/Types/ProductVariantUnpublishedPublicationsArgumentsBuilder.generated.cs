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
    public sealed class ProductVariantUnpublishedPublicationsArgumentsBuilder : ArgumentsBuilderBase<PublicationConnection?, ProductVariantUnpublishedPublicationsArgumentsBuilder>
    {
        protected override ProductVariantUnpublishedPublicationsArgumentsBuilder Self => this;

        public ProductVariantUnpublishedPublicationsArgumentsBuilder(IQuery<PublicationConnection?> query) : base(query)
        {
        }

        public ProductVariantUnpublishedPublicationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ProductVariantUnpublishedPublicationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ProductVariantUnpublishedPublicationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ProductVariantUnpublishedPublicationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ProductVariantUnpublishedPublicationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}