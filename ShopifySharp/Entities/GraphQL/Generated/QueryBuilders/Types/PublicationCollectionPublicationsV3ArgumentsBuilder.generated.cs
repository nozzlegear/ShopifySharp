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
    public sealed class PublicationCollectionPublicationsV3ArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationConnection?, PublicationCollectionPublicationsV3ArgumentsBuilder>
    {
        protected override PublicationCollectionPublicationsV3ArgumentsBuilder Self => this;

        public PublicationCollectionPublicationsV3ArgumentsBuilder(IQuery<ResourcePublicationConnection?> query) : base(query)
        {
        }

        public PublicationCollectionPublicationsV3ArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PublicationCollectionPublicationsV3ArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PublicationCollectionPublicationsV3ArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PublicationCollectionPublicationsV3ArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PublicationCollectionPublicationsV3ArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}