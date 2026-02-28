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
    public sealed class ReturnReturnLineItemsArgumentsBuilder : ArgumentsBuilderBase<ReturnLineItemTypeConnection?, ReturnReturnLineItemsArgumentsBuilder>
    {
        protected override ReturnReturnLineItemsArgumentsBuilder Self => this;

        public ReturnReturnLineItemsArgumentsBuilder(IQuery<ReturnLineItemTypeConnection?> query) : base(query)
        {
        }

        public ReturnReturnLineItemsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ReturnReturnLineItemsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ReturnReturnLineItemsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ReturnReturnLineItemsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ReturnReturnLineItemsArgumentsBuilder ProcessingStatus(ReturnProcessingStatusFilterInput? processingStatus)
        {
            base.InnerQuery.AddArgument("processingStatus", processingStatus);
            return this;
        }

        public ReturnReturnLineItemsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}