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
    public sealed class QueryRootCollectionConditionsSourcesByAppArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourcesByAppConnection?, QueryRootCollectionConditionsSourcesByAppArgumentsBuilder>
    {
        protected override QueryRootCollectionConditionsSourcesByAppArgumentsBuilder Self => this;

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder(IQuery<CollectionConditionsSourcesByAppConnection?> query) : base(query)
        {
        }

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootCollectionConditionsSourcesByAppArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}