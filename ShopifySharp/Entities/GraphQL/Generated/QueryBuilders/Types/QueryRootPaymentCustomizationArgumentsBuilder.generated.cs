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
    public sealed class QueryRootPaymentCustomizationArgumentsBuilder : ArgumentsBuilderBase<PaymentCustomization?, QueryRootPaymentCustomizationArgumentsBuilder>
    {
        protected override QueryRootPaymentCustomizationArgumentsBuilder Self => this;

        public QueryRootPaymentCustomizationArgumentsBuilder(IQuery<PaymentCustomization?> query) : base(query)
        {
        }

        public QueryRootPaymentCustomizationArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}