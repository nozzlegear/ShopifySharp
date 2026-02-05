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
    public sealed class CompanyDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyDeletePayload, CompanyDeleteArgumentsBuilder>
    {
        protected override CompanyDeleteArgumentsBuilder Self => this;

        public CompanyDeleteArgumentsBuilder(IQuery<CompanyDeletePayload> query) : base(query)
        {
        }

        public CompanyDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}