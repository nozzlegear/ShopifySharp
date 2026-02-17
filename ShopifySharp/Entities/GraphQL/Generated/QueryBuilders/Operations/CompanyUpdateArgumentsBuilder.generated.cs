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
    public sealed class CompanyUpdateArgumentsBuilder : ArgumentsBuilderBase<CompanyUpdatePayload, CompanyUpdateArgumentsBuilder>
    {
        protected override CompanyUpdateArgumentsBuilder Self => this;

        public CompanyUpdateArgumentsBuilder(IQuery<CompanyUpdatePayload> query) : base(query)
        {
        }

        public CompanyUpdateArgumentsBuilder CompanyId(string? companyId)
        {
            base.InnerQuery.AddArgument("companyId", companyId);
            return this;
        }

        public CompanyUpdateArgumentsBuilder Input(CompanyInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}