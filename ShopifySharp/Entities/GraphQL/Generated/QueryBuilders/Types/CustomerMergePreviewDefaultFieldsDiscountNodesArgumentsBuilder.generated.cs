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
    public sealed class CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder : ArgumentsBuilderBase<DiscountNodeConnection?, CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder>
    {
        protected override CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder(IQuery<DiscountNodeConnection?> query) : base(query)
        {
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDiscountNodesArgumentsBuilder SortKey(DiscountSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}