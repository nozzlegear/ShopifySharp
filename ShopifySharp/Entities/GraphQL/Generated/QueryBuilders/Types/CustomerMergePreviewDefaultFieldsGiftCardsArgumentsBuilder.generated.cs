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
    public sealed class CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder : ArgumentsBuilderBase<GiftCardConnection?, CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder>
    {
        protected override CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder(IQuery<GiftCardConnection?> query) : base(query)
        {
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder SortKey(GiftCardSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}