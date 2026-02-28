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
    public sealed class PublicationProductsArgumentsBuilder : ArgumentsBuilderBase<ProductConnection?, PublicationProductsArgumentsBuilder>
    {
        protected override PublicationProductsArgumentsBuilder Self => this;

        public PublicationProductsArgumentsBuilder(IQuery<ProductConnection?> query) : base(query)
        {
        }

        public PublicationProductsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PublicationProductsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PublicationProductsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PublicationProductsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PublicationProductsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public PublicationProductsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PublicationProductsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public PublicationProductsArgumentsBuilder SortKey(ProductSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}