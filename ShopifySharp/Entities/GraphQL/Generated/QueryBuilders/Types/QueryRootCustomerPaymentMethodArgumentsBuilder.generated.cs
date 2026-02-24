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
    public sealed class QueryRootCustomerPaymentMethodArgumentsBuilder : ArgumentsBuilderBase<CustomerPaymentMethod?, QueryRootCustomerPaymentMethodArgumentsBuilder>
    {
        protected override QueryRootCustomerPaymentMethodArgumentsBuilder Self => this;

        public QueryRootCustomerPaymentMethodArgumentsBuilder(IQuery<CustomerPaymentMethod?> query) : base(query)
        {
        }

        public QueryRootCustomerPaymentMethodArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public QueryRootCustomerPaymentMethodArgumentsBuilder ShowRevoked(bool? showRevoked)
        {
            base.InnerQuery.AddArgument("showRevoked", showRevoked);
            return this;
        }
    }
}