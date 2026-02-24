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
    public sealed class PublicationProductPublicationsV3ArgumentsBuilder : ArgumentsBuilderBase<ResourcePublicationConnection?, PublicationProductPublicationsV3ArgumentsBuilder>
    {
        protected override PublicationProductPublicationsV3ArgumentsBuilder Self => this;

        public PublicationProductPublicationsV3ArgumentsBuilder(IQuery<ResourcePublicationConnection?> query) : base(query)
        {
        }

        public PublicationProductPublicationsV3ArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PublicationProductPublicationsV3ArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PublicationProductPublicationsV3ArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PublicationProductPublicationsV3ArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PublicationProductPublicationsV3ArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}