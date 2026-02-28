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
    public sealed class ExchangeLineItemConnectionArgumentsBuilder : ArgumentsBuilderBase<ExchangeLineItemConnection, ExchangeLineItemConnectionArgumentsBuilder>
    {
        protected override ExchangeLineItemConnectionArgumentsBuilder Self => this;

        public ExchangeLineItemConnectionArgumentsBuilder(IQuery<ExchangeLineItemConnection> query) : base(query)
        {
        }

        public ExchangeLineItemConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder IncludeRemovedItems(bool? includeRemovedItems)
        {
            base.InnerQuery.AddArgument("includeRemovedItems", includeRemovedItems);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder ProcessingStatus(ReturnProcessingStatusFilterInput? processingStatus)
        {
            base.InnerQuery.AddArgument("processingStatus", processingStatus);
            return this;
        }

        public ExchangeLineItemConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}