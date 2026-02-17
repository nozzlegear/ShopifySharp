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
    public sealed class CompanyContactRemoveFromCompanyArgumentsBuilder : ArgumentsBuilderBase<CompanyContactRemoveFromCompanyPayload, CompanyContactRemoveFromCompanyArgumentsBuilder>
    {
        protected override CompanyContactRemoveFromCompanyArgumentsBuilder Self => this;

        public CompanyContactRemoveFromCompanyArgumentsBuilder(IQuery<CompanyContactRemoveFromCompanyPayload> query) : base(query)
        {
        }

        public CompanyContactRemoveFromCompanyArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }
    }
}