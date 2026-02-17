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