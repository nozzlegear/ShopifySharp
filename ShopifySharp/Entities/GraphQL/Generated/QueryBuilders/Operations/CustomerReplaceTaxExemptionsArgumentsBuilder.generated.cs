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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerReplaceTaxExemptionsArgumentsBuilder : ArgumentsBuilderBase<CustomerReplaceTaxExemptionsPayload, CustomerReplaceTaxExemptionsArgumentsBuilder>
    {
        protected override CustomerReplaceTaxExemptionsArgumentsBuilder Self => this;

        public CustomerReplaceTaxExemptionsArgumentsBuilder(IQuery<CustomerReplaceTaxExemptionsPayload> query) : base(query)
        {
        }

        public CustomerReplaceTaxExemptionsArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerReplaceTaxExemptionsArgumentsBuilder TaxExemptions(ICollection<TaxExemption>? taxExemptions)
        {
            base.InnerQuery.AddArgument("taxExemptions", taxExemptions);
            return this;
        }
    }
}