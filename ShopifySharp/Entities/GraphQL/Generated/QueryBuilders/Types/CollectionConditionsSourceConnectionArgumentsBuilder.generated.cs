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
    public sealed class CollectionConditionsSourceConnectionArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourceConnection, CollectionConditionsSourceConnectionArgumentsBuilder>
    {
        protected override CollectionConditionsSourceConnectionArgumentsBuilder Self => this;

        public CollectionConditionsSourceConnectionArgumentsBuilder(IQuery<CollectionConditionsSourceConnection> query) : base(query)
        {
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder SortKey(CollectionConditionsSourceSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public CollectionConditionsSourceConnectionArgumentsBuilder AppId(string? appId)
        {
            base.InnerQuery.AddArgument("appId", appId);
            return this;
        }
    }
}