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
    public sealed class PriceRuleDiscountCodesArgumentsBuilder : ArgumentsBuilderBase<PriceRuleDiscountCodeConnection?, PriceRuleDiscountCodesArgumentsBuilder>
    {
        protected override PriceRuleDiscountCodesArgumentsBuilder Self => this;

        public PriceRuleDiscountCodesArgumentsBuilder(IQuery<PriceRuleDiscountCodeConnection?> query) : base(query)
        {
        }

        public PriceRuleDiscountCodesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public PriceRuleDiscountCodesArgumentsBuilder SortKey(DiscountCodeSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}