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
    public sealed class CompanyLocationAssignTaxExemptionsArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationAssignTaxExemptionsPayload, CompanyLocationAssignTaxExemptionsArgumentsBuilder>
    {
        protected override CompanyLocationAssignTaxExemptionsArgumentsBuilder Self => this;

        public CompanyLocationAssignTaxExemptionsArgumentsBuilder(IQuery<CompanyLocationAssignTaxExemptionsPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignTaxExemptionsArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationAssignTaxExemptionsArgumentsBuilder TaxExemptions(ICollection<TaxExemption>? taxExemptions)
        {
            base.InnerQuery.AddArgument("taxExemptions", taxExemptions);
            return this;
        }
    }
}