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
    public sealed class CompaniesDeleteArgumentsBuilder : ArgumentsBuilderBase<CompaniesDeletePayload, CompaniesDeleteArgumentsBuilder>
    {
        protected override CompaniesDeleteArgumentsBuilder Self => this;

        public CompaniesDeleteArgumentsBuilder(IQuery<CompaniesDeletePayload> query) : base(query)
        {
        }

        public CompaniesDeleteArgumentsBuilder CompanyIds(ICollection<string>? companyIds)
        {
            base.InnerQuery.AddArgument("companyIds", companyIds);
            return this;
        }
    }
}