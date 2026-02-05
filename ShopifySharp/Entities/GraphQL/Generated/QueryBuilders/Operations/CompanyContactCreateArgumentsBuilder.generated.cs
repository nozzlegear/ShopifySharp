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
    public sealed class CompanyContactCreateArgumentsBuilder : ArgumentsBuilderBase<CompanyContactCreatePayload, CompanyContactCreateArgumentsBuilder>
    {
        protected override CompanyContactCreateArgumentsBuilder Self => this;

        public CompanyContactCreateArgumentsBuilder(IQuery<CompanyContactCreatePayload> query) : base(query)
        {
        }

        public CompanyContactCreateArgumentsBuilder CompanyId(string? companyId)
        {
            base.InnerQuery.AddArgument("companyId", companyId);
            return this;
        }

        public CompanyContactCreateArgumentsBuilder Input(CompanyContactInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}