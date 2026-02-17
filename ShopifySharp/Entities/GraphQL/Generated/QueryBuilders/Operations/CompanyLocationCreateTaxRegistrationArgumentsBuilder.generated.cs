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