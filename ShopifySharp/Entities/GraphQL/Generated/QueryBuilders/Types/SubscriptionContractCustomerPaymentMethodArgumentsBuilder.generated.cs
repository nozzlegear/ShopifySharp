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
    public sealed class SubscriptionContractCustomerPaymentMethodArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethod?, SubscriptionContractCustomerPaymentMethodArgumentsBuilder>
    {
        protected override SubscriptionContractCustomerPaymentMethodArgumentsBuilder Self => this;

        public SubscriptionContractCustomerPaymentMethodArgumentsBuilder(IQuery<CustomerPaymentMethod?> query) : base(query)
        {
        }

        public SubscriptionContractCustomerPaymentMethodArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}