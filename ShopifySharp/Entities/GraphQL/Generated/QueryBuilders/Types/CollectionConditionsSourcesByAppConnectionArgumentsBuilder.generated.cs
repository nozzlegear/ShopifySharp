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
    public sealed class CollectionConditionsSourcesByAppConnectionArgumentsBuilder : ArgumentsBuilderBase<CollectionConditionsSourcesByAppConnection, CollectionConditionsSourcesByAppConnectionArgumentsBuilder>
    {
        protected override CollectionConditionsSourcesByAppConnectionArgumentsBuilder Self => this;

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder(IQuery<CollectionConditionsSourcesByAppConnection> query) : base(query)
        {
        }

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}