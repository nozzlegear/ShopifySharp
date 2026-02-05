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
    public sealed class CompanyLocationRevokeTaxRegistrationArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationRevokeTaxRegistrationPayload, CompanyLocationRevokeTaxRegistrationArgumentsBuilder>
    {
        protected override CompanyLocationRevokeTaxRegistrationArgumentsBuilder Self => this;

        public CompanyLocationRevokeTaxRegistrationArgumentsBuilder(IQuery<CompanyLocationRevokeTaxRegistrationPayload> query) : base(query)
        {
        }

        public CompanyLocationRevokeTaxRegistrationArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }
    }
}