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
    public sealed class CompanyLocationCreateTaxRegistrationArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationCreateTaxRegistrationPayload, CompanyLocationCreateTaxRegistrationArgumentsBuilder>
    {
        protected override CompanyLocationCreateTaxRegistrationArgumentsBuilder Self => this;

        public CompanyLocationCreateTaxRegistrationArgumentsBuilder(IQuery<CompanyLocationCreateTaxRegistrationPayload> query) : base(query)
        {
        }

        public CompanyLocationCreateTaxRegistrationArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public CompanyLocationCreateTaxRegistrationArgumentsBuilder TaxId(string? taxId)
        {
            base.InnerQuery.AddArgument("taxId", taxId);
            return this;
        }
    }
}