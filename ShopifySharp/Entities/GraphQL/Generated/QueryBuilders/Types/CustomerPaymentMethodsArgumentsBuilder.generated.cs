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
    public sealed class CustomerPaymentMethodsArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodConnection?, CustomerPaymentMethodsArgumentsBuilder>
    {
        protected override CustomerPaymentMethodsArgumentsBuilder Self => this;

        public CustomerPaymentMethodsArgumentsBuilder(IQuery<CustomerPaymentMethodConnection?> query) : base(query)
        {
        }

        public CustomerPaymentMethodsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerPaymentMethodsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerPaymentMethodsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerPaymentMethodsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerPaymentMethodsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerPaymentMethodsArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}