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
    public sealed class ShopifyPaymentsBankAccountConnectionArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsBankAccountConnection, ShopifyPaymentsBankAccountConnectionArgumentsBuilder>
    {
        protected override ShopifyPaymentsBankAccountConnectionArgumentsBuilder Self => this;

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder(IQuery<ShopifyPaymentsBankAccountConnection> query) : base(query)
        {
        }

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsBankAccountConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}