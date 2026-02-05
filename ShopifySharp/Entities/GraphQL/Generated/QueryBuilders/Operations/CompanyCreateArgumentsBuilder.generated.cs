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
    public sealed class CompanyCreateArgumentsBuilder : ArgumentsBuilderBase<CompanyCreatePayload, CompanyCreateArgumentsBuilder>
    {
        protected override CompanyCreateArgumentsBuilder Self => this;

        public CompanyCreateArgumentsBuilder(IQuery<CompanyCreatePayload> query) : base(query)
        {
        }

        public CompanyCreateArgumentsBuilder Input(CompanyCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}