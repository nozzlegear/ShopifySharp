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
    public sealed class CustomerPaymentMethodGetDuplicationDataArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethodGetDuplicationDataPayload, CustomerPaymentMethodGetDuplicationDataArgumentsBuilder>
    {
        protected override CustomerPaymentMethodGetDuplicationDataArgumentsBuilder Self => this;

        public CustomerPaymentMethodGetDuplicationDataArgumentsBuilder(IQuery<CustomerPaymentMethodGetDuplicationDataPayload> query) : base(query)
        {
        }

        public CustomerPaymentMethodGetDuplicationDataArgumentsBuilder CustomerPaymentMethodId(string? customerPaymentMethodId)
        {
            base.InnerQuery.AddArgument("customerPaymentMethodId", customerPaymentMethodId);
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataArgumentsBuilder TargetCustomerId(string? targetCustomerId)
        {
            base.InnerQuery.AddArgument("targetCustomerId", targetCustomerId);
            return this;
        }

        public CustomerPaymentMethodGetDuplicationDataArgumentsBuilder TargetShopId(string? targetShopId)
        {
            base.InnerQuery.AddArgument("targetShopId", targetShopId);
            return this;
        }
    }
}