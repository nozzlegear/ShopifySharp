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
    public sealed class CollectionSourceExclusionSelectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionExclusionProductSelectionConnection?, CollectionSourceExclusionSelectionsArgumentsBuilder>
    {
        protected override CollectionSourceExclusionSelectionsArgumentsBuilder Self => this;

        public CollectionSourceExclusionSelectionsArgumentsBuilder(IQuery<CollectionExclusionProductSelectionConnection?> query) : base(query)
        {
        }

        public CollectionSourceExclusionSelectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CollectionSourceExclusionSelectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CollectionSourceExclusionSelectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CollectionSourceExclusionSelectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CollectionSourceExclusionSelectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}