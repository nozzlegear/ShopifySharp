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
    public sealed class CustomerPaymentMethodMandatesArgumentsBuilder : ArgumentsBuilderBase<PaymentMandateResourceConnection?, CustomerPaymentMethodMandatesArgumentsBuilder>
    {
        protected override CustomerPaymentMethodMandatesArgumentsBuilder Self => this;

        public CustomerPaymentMethodMandatesArgumentsBuilder(IQuery<PaymentMandateResourceConnection?> query) : base(query)
        {
        }

        public CustomerPaymentMethodMandatesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerPaymentMethodMandatesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerPaymentMethodMandatesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerPaymentMethodMandatesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerPaymentMethodMandatesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}