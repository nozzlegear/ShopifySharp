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
    public sealed class CustomerAddTaxExemptionsArgumentsBuilder : ArgumentsBuilderBase<CustomerAddTaxExemptionsPayload, CustomerAddTaxExemptionsArgumentsBuilder>
    {
        protected override CustomerAddTaxExemptionsArgumentsBuilder Self => this;

        public CustomerAddTaxExemptionsArgumentsBuilder(IQuery<CustomerAddTaxExemptionsPayload> query) : base(query)
        {
        }

        public CustomerAddTaxExemptionsArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerAddTaxExemptionsArgumentsBuilder TaxExemptions(ICollection<TaxExemption>? taxExemptions)
        {
            base.InnerQuery.AddArgument("taxExemptions", taxExemptions);
            return this;
        }
    }
}