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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CompanyLocationCatalogsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, CompanyLocationCatalogsCountArgumentsBuilder>
    {
        protected override CompanyLocationCatalogsCountArgumentsBuilder Self => this;

        public CompanyLocationCatalogsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public CompanyLocationCatalogsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }
    }
}