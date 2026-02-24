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
    public sealed class QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder : ArgumentsBuilderBase<SavedSearchConnection?, QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder>
    {
        protected override QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder Self => this;

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder(IQuery<SavedSearchConnection?> query) : base(query)
        {
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootDiscountRedeemCodeSavedSearchesArgumentsBuilder SortKey(DiscountCodeSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}