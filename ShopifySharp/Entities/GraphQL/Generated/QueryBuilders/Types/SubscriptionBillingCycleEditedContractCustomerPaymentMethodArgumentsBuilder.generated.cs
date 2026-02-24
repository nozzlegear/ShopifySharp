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
    public sealed class SubscriptionBillingCycleEditedContractCustomerPaymentMethodArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethod?, SubscriptionBillingCycleEditedContractCustomerPaymentMethodArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleEditedContractCustomerPaymentMethodArgumentsBuilder Self => this;

        public SubscriptionBillingCycleEditedContractCustomerPaymentMethodArgumentsBuilder(IQuery<CustomerPaymentMethod?> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEditedContractCustomerPaymentMethodArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}