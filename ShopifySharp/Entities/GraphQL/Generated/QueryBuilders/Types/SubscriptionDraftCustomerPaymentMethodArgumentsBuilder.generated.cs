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
    public sealed class SubscriptionDraftCustomerPaymentMethodArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethod?, SubscriptionDraftCustomerPaymentMethodArgumentsBuilder>
    {
        protected override SubscriptionDraftCustomerPaymentMethodArgumentsBuilder Self => this;

        public SubscriptionDraftCustomerPaymentMethodArgumentsBuilder(IQuery<CustomerPaymentMethod?> query) : base(query)
        {
        }

        public SubscriptionDraftCustomerPaymentMethodArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}