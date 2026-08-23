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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CollectionConditionsSourcesByAppArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourcesByAppConnection, CollectionConditionsSourcesByAppArgumentsBuilder>
    {
        protected override CollectionConditionsSourcesByAppArgumentsBuilder Self => this;

        public CollectionConditionsSourcesByAppArgumentsBuilder(IQuery<CollectionConditionsSourcesByAppConnection> query) : base(query)
        {
        }

        public CollectionConditionsSourcesByAppArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionConditionsSourcesByAppArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionConditionsSourcesByAppArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionConditionsSourcesByAppArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionConditionsSourcesByAppArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}