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
    public sealed class CombinedListingCombinedListingChildrenArgumentsBuilder : ArgumentsBuilderBase<CombinedListingChildConnection?, CombinedListingCombinedListingChildrenArgumentsBuilder>
    {
        protected override CombinedListingCombinedListingChildrenArgumentsBuilder Self => this;

        public CombinedListingCombinedListingChildrenArgumentsBuilder(IQuery<CombinedListingChildConnection?> query) : base(query)
        {
        }

        public CombinedListingCombinedListingChildrenArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CombinedListingCombinedListingChildrenArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CombinedListingCombinedListingChildrenArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CombinedListingCombinedListingChildrenArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CombinedListingCombinedListingChildrenArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}