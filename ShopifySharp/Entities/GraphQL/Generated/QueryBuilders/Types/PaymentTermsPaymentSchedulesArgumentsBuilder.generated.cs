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
    public sealed class PaymentTermsPaymentSchedulesArgumentsBuilder : ArgumentsBuilderBase<PaymentScheduleConnection?, PaymentTermsPaymentSchedulesArgumentsBuilder>
    {
        protected override PaymentTermsPaymentSchedulesArgumentsBuilder Self => this;

        public PaymentTermsPaymentSchedulesArgumentsBuilder(IQuery<PaymentScheduleConnection?> query) : base(query)
        {
        }

        public PaymentTermsPaymentSchedulesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PaymentTermsPaymentSchedulesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PaymentTermsPaymentSchedulesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PaymentTermsPaymentSchedulesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PaymentTermsPaymentSchedulesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}