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
    public sealed class CompanyLocationRevokeTaxExemptionsArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationRevokeTaxExemptionsPayload, CompanyLocationRevokeTaxExemptionsArgumentsBuilder>
    {
        protected override CompanyLocationRevokeTaxExemptionsArgumentsBuilder Self => this;

        public CompanyLocationRevokeTaxExemptionsArgumentsBuilder(IQuery<CompanyLocationRevokeTaxExemptionsPayload> query) : base(query)
        {
        }

        public CompanyLocationRevokeTaxExemptionsArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationRevokeTaxExemptionsArgumentsBuilder TaxExemptions(ICollection<TaxExemption>? taxExemptions)
        {
            base.InnerQuery.AddArgument("taxExemptions", taxExemptions);
            return this;
        }
    }
}