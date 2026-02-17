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
    public sealed class CompanyContactUpdateArgumentsBuilder : ArgumentsBuilderBase<CompanyContactUpdatePayload, CompanyContactUpdateArgumentsBuilder>
    {
        protected override CompanyContactUpdateArgumentsBuilder Self => this;

        public CompanyContactUpdateArgumentsBuilder(IQuery<CompanyContactUpdatePayload> query) : base(query)
        {
        }

        public CompanyContactUpdateArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactUpdateArgumentsBuilder Input(CompanyContactInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}