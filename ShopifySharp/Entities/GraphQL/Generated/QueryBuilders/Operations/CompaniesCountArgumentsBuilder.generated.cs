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
    public sealed class CompaniesCountArgumentsBuilder : ArgumentsBuilderBase<Count, CompaniesCountArgumentsBuilder>
    {
        protected override CompaniesCountArgumentsBuilder Self => this;

        public CompaniesCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public CompaniesCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }
    }
}