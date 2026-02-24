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
    public sealed class AbandonedCheckoutLineItemConnectionArgumentsBuilder : ArgumentsBuilderBase<AbandonedCheckoutLineItemConnection, AbandonedCheckoutLineItemConnectionArgumentsBuilder>
    {
        protected override AbandonedCheckoutLineItemConnectionArgumentsBuilder Self => this;

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder(IQuery<AbandonedCheckoutLineItemConnection> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AbandonedCheckoutLineItemConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}