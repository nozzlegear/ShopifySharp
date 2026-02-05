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
    public sealed class CompanyLocationUpdateArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationUpdatePayload, CompanyLocationUpdateArgumentsBuilder>
    {
        protected override CompanyLocationUpdateArgumentsBuilder Self => this;

        public CompanyLocationUpdateArgumentsBuilder(IQuery<CompanyLocationUpdatePayload> query) : base(query)
        {
        }

        public CompanyLocationUpdateArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationUpdateArgumentsBuilder Input(CompanyLocationUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}