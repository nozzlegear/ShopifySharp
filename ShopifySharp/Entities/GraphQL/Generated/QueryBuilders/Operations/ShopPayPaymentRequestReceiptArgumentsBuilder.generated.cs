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
    public sealed class ShopPayPaymentRequestReceiptArgumentsBuilder : ArgumentsBuilderBase<ShopPayPaymentRequestReceipt, ShopPayPaymentRequestReceiptArgumentsBuilder>
    {
        protected override ShopPayPaymentRequestReceiptArgumentsBuilder Self => this;

        public ShopPayPaymentRequestReceiptArgumentsBuilder(IQuery<ShopPayPaymentRequestReceipt> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptArgumentsBuilder Token(string? token)
        {
            base.InnerQuery.AddArgument("token", token);
            return this;
        }
    }
}