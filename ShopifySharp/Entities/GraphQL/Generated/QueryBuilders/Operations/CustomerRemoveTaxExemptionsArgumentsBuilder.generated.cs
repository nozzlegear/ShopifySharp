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
    public sealed class CustomerRemoveTaxExemptionsArgumentsBuilder : ArgumentsBuilderBase<CustomerRemoveTaxExemptionsPayload, CustomerRemoveTaxExemptionsArgumentsBuilder>
    {
        protected override CustomerRemoveTaxExemptionsArgumentsBuilder Self => this;

        public CustomerRemoveTaxExemptionsArgumentsBuilder(IQuery<CustomerRemoveTaxExemptionsPayload> query) : base(query)
        {
        }

        public CustomerRemoveTaxExemptionsArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerRemoveTaxExemptionsArgumentsBuilder TaxExemptions(ICollection<TaxExemption>? taxExemptions)
        {
            base.InnerQuery.AddArgument("taxExemptions", taxExemptions);
            return this;
        }
    }
}