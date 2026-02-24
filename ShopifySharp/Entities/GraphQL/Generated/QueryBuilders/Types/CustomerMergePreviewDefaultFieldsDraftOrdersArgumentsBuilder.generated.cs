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
    public sealed class CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder : ArgumentsBuilderBase<DraftOrderConnection?, CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder>
    {
        protected override CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder(IQuery<DraftOrderConnection?> query) : base(query)
        {
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder SortKey(DraftOrderSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}