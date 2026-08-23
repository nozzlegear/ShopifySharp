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
    public sealed class CollectionExclusionProductSelectionConnectionArgumentsBuilder : ArgumentsBuilderBase<CollectionExclusionProductSelectionConnection, CollectionExclusionProductSelectionConnectionArgumentsBuilder>
    {
        protected override CollectionExclusionProductSelectionConnectionArgumentsBuilder Self => this;

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder(IQuery<CollectionExclusionProductSelectionConnection> query) : base(query)
        {
        }

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}