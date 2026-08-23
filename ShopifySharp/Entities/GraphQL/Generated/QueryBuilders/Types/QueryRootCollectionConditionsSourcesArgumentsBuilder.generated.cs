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
    public sealed class QueryRootCollectionConditionsSourcesArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourceConnection?, QueryRootCollectionConditionsSourcesArgumentsBuilder>
    {
        protected override QueryRootCollectionConditionsSourcesArgumentsBuilder Self => this;

        public QueryRootCollectionConditionsSourcesArgumentsBuilder(IQuery<CollectionConditionsSourceConnection?> query) : base(query)
        {
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder AppId(string? appId)
        {
            base.InnerQuery.AddArgument("appId", appId);
            return this;
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootCollectionConditionsSourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}