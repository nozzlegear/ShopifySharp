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