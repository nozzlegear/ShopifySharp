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
    public sealed class PurchasingEntityPaymentMethodsArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodConnection?, PurchasingEntityPaymentMethodsArgumentsBuilder>
    {
        protected override PurchasingEntityPaymentMethodsArgumentsBuilder Self => this;

        public PurchasingEntityPaymentMethodsArgumentsBuilder(IQuery<CustomerPaymentMethodConnection?> query) : base(query)
        {
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PurchasingEntityPaymentMethodsArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}