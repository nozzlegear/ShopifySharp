#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class AutomaticDiscountSavedSearchesArgumentsBuilder : ArgumentsBuilderBase<SavedSearchConnection, AutomaticDiscountSavedSearchesArgumentsBuilder>
    {
        protected override AutomaticDiscountSavedSearchesArgumentsBuilder Self => this;

        public AutomaticDiscountSavedSearchesArgumentsBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
        }

        public AutomaticDiscountSavedSearchesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AutomaticDiscountSavedSearchesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AutomaticDiscountSavedSearchesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AutomaticDiscountSavedSearchesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AutomaticDiscountSavedSearchesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}