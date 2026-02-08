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
    public sealed class CodeDiscountSavedSearchesArgumentsBuilder : ArgumentsBuilderBase<SavedSearchConnection, CodeDiscountSavedSearchesArgumentsBuilder>
    {
        protected override CodeDiscountSavedSearchesArgumentsBuilder Self => this;

        public CodeDiscountSavedSearchesArgumentsBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
        }

        public CodeDiscountSavedSearchesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CodeDiscountSavedSearchesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CodeDiscountSavedSearchesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CodeDiscountSavedSearchesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CodeDiscountSavedSearchesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}