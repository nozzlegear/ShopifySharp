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
    public sealed class CollectionConditionsSourcesByAppSourcesArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourceConnection?, CollectionConditionsSourcesByAppSourcesArgumentsBuilder>
    {
        protected override CollectionConditionsSourcesByAppSourcesArgumentsBuilder Self => this;

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder(IQuery<CollectionConditionsSourceConnection?> query) : base(query)
        {
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CollectionConditionsSourcesByAppSourcesArgumentsBuilder SortKey(CollectionConditionsSourceSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}